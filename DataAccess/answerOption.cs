using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace pollService.DataAccess
{
    /// <summary>
    /// вариант ответа
    /// </summary>
    public class AnswerOption
    {
        public int Id { get; set; }
        /// <summary>
        /// заголовое варианта
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// корректность варианта
        /// </summary>
        public bool Correct { get; set; }

        /// <summary>
        /// признак того, что пользователь выбрал вариант
        /// </summary>
        [NotMapped]
        public bool Checked { get; set; }
    }
}