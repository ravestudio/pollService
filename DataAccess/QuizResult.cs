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
}
