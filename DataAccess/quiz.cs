using System;
using System.Collections.Generic;

namespace pollService.DataAccess
{
    /// <summary>
    /// сущность БД тест
    /// </summary>
    public class Quiz
    {
        public int Id { get; set; }
        /// <summary>
        /// Заголовок теста
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Ссылка на тетс
        /// </summary>
        public string Permalink { get; set; }
        /// <summary>
        /// список вопросов
        /// </summary>
        public ICollection<Question> Questions { get; set; }
    }
}