using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace pollService.DataAccess
{
    public class AnswerOption
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Correct { get; set; }

        /// <summary>
        /// User selected this answer
        /// </summary>
        [NotMapped]
        public bool Checked { get; set; }

        //public virtual Question Question { get; set; }
    }
}