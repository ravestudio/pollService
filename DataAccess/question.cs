using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace pollService.DataAccess
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<AnswerOption> AnswerOptions { get; set; }

        public string TextAnswer { get; set; }
        /// <summary>
        /// id answer option that the user chose 
        /// </summary>
        [NotMapped]
        public int UserAnswer { get; set; }

        [NotMapped]
        public string UserTextAnswer { get; set; }
        //public Quiz Quiz { get; set; }

        public int QuestionType { get; set; }
    }
}