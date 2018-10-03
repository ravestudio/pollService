using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace pollService.DataAccess
{
    /// <summary>
    /// Сущность вопросов
    /// </summary>
    public class Question
    {
        public int Id { get; set; }
        /// <summary>
        /// Заголовок вопроса
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Список ответов
        /// </summary>
        public ICollection<AnswerOption> AnswerOptions { get; set; }

        /// <summary>
        /// текст ответа
        /// </summary>
        public string TextAnswer { get; set; }
        /// <summary>
        /// ответ пользователя
        /// </summary>
        [NotMapped]
        public int UserAnswer { get; set; }

        /// <summary>
        /// ответ пользователя, произвольной формы
        /// </summary>
        [NotMapped]
        public string UserTextAnswer { get; set; }
        
        /// <summary>
        /// тип вопроса
        /// </summary>
        public int QuestionType { get; set; }
    }
}