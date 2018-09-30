using System;

namespace pollService.DataAccess
{
    public class AnswerOption
    {
        public int Id { get; set; }
        public int QuestionId {get; set;}
        public string Title { get; set; }
        public bool Correct {get; set;}
    }
}