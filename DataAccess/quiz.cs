using System;
using System.Collections.Generic;

namespace pollService.DataAccess
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Permalink { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}