using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using pollService.DataAccess;

namespace pollService.Controllers
{
    /// <summary>
    /// контроллер для записи результатов, и получения статистики
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {

        /// <summary>
        /// получить статистику по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Statistics Get(int id)
        {
            QuizResult qResult = null;

            using (var db = new PollContext())
            {
                qResult = db.QuizResultSet.Single(r => r.Id == id);
            }

            var statistics = JsonConvert.DeserializeObject<Statistics>(qResult.Result);

            return statistics;
        }

        /// <summary>
        /// сохранить результат тетирования
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Quiz value)
        {
            var statstic = new Statistics()
            {
                QuestionsCount = value.Questions.Count,
                Items = new List<StatisticItem>()
            };

            Quiz originalQuiz = null;

            //получить из базы вопрос с ответами
            using (var db = new PollContext())
            {
                originalQuiz = db.QuizSet.Include("Questions").Include("Questions.AnswerOptions").Single(q => q.Id == value.Id);
            }

            //сверить ответы пользователя с реальными, и записать ответы
            foreach(var question in value.Questions)
            {
                var originalQuest = originalQuiz.Questions.Single(q => q.Id == question.Id);

                if (originalQuest.QuestionType == 1)
                {
                    statstic.Items.Add(new StatisticItem()
                    {
                        QuestionId = originalQuest.Id,
                        CorrectAnswer = question.UserAnswer == originalQuest.AnswerOptions.Single(o => o.Correct).Id,
                        AnswersOptions = new List<int>() { question.UserAnswer }
                    });
                }

                
                if (originalQuest.QuestionType == 2)
                {
                    var userAnswers = question.AnswerOptions.Where(o => o.Checked).Select(o => o.Id);
                    var correctAnswers = originalQuest.AnswerOptions.Where(o => o.Correct).Select(o => o.Id);

                    statstic.Items.Add(new StatisticItem()
                    {
                        QuestionId = originalQuest.Id,
                        CorrectAnswer = userAnswers.Count() == correctAnswers.Count() && userAnswers.Intersect(correctAnswers).Count() == userAnswers.Count(),
                        AnswersOptions = userAnswers.ToList()
                    });

                }

                if (originalQuest.QuestionType == 3)
                {
                    statstic.Items.Add(new StatisticItem()
                    {
                        QuestionId = originalQuest.Id,
                        CorrectAnswer = question.UserTextAnswer.ToUpper() == originalQuest.TextAnswer.ToUpper(),
                        TextAnswer = question.UserTextAnswer
                    });

                }
            }

            //посчитать количество верных ответов
            statstic.CorrectAnswersCount = statstic.Items.Count(i => i.CorrectAnswer);

            var jsonString = JsonConvert.SerializeObject(statstic);

            QuizResult quizResult = null;

            //сохранить результат для статистики, в json формате
            using (var db = new PollContext())
            {
                quizResult = new QuizResult()
                {
                    Quiz = db.QuizSet.Single(q => q.Id == value.Id),
                    Date = DateTime.Now,
                    Result = jsonString
                };

                db.QuizResultSet.Add(quizResult);
                db.SaveChanges();

            }


            return Ok(quizResult.Id);
        }
    }
}