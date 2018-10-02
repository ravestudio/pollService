using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pollService.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace pollService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Quiz> Get()
        {
            IEnumerable<Quiz> quizzes = null;

            using(var db = new PollContext())
            {
                quizzes = db.QuizSet.ToList();
            }

            return quizzes;
        }

        [HttpGet("{permalink}")]
        public Quiz Get(string permalink)
        {
            Quiz result = null;

            using(var db = new PollContext())
            {
                result = db.QuizSet.Include("Questions").Include("Questions.AnswerOptions").Single(q => q.Permalink == permalink);
            }

            //hide correct answers
            foreach(var question in result.Questions)
            {
                question.TextAnswer = null;

                foreach(var answer in question.AnswerOptions)
                {
                    answer.Correct = false;
                }
            }

            return result;
        }

    }
}