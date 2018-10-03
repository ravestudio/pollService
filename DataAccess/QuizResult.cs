using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollService.DataAccess
{
    /// <summary>
    /// результат ответа
    /// </summary>
    public class QuizResult
    {
        public int Id { get; set; }
        /// <summary>
        /// дата, время ответа
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// ссылка на тетс
        /// </summary>
        public Quiz Quiz { get; set; }


       /// <summary>
       /// результат тестирования, json
       /// </summary>
        public string Result { get; set; }
    }

    /// <summary>
    /// статистика
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// общее количество вопросов
        /// </summary>
        public int QuestionsCount { get; set; }
        /// <summary>
        /// количетсво верных ответов
        /// </summary>
        public int CorrectAnswersCount { get; set; }

        /// <summary>
        /// ответы на вопросы пользователя
        /// </summary>
        public List<StatisticItem> Items { get; set; }

    }

    public class StatisticItem
    {
       /// <summary>
       /// идентификатов ответа
       /// </summary>
        public int QuestionId { get; set; }

        /// <summary>
        /// ответ верный
        /// </summary>
        public bool CorrectAnswer { get; set; }

        /// <summary>
        /// вырианты которые выбрал пользователь
        /// </summary>
        public List<int> AnswersOptions { get; set; }

        /// <summary>
        /// произвольный ответ пользователя
        /// </summary>
        public string TextAnswer { get; set; }
    }
}
