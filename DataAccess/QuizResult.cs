using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollService.DataAccess
{
    public class QuizResult
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public Quiz Quiz { get; set; }

        public string Result { get; set; }
    }

    public class Statistics
    {
        public int QuestionsCount { get; set; }
        public int CorrectAnswersCount { get; set; }

        public List<StatisticItem> Items { get; set; }

    }

    public class StatisticItem
    {
        public int QuestionId { get; set; }

        public bool CorrectAnswer { get; set; }

        public List<int> AnswersOptions { get; set; }
        public string TextAnswer { get; set; }
    }
}
