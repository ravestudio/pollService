using System;
using System.Collections.Generic;

namespace pollService.DataAccess
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<AnswerOption> AnswerOptions {get; set;}
    }
}