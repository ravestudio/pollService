using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace pollService.DataAccess
{
    /// <summary>
    /// �������� ��������
    /// </summary>
    public class Question
    {
        public int Id { get; set; }
        /// <summary>
        /// ��������� �������
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// ������ �������
        /// </summary>
        public ICollection<AnswerOption> AnswerOptions { get; set; }

        /// <summary>
        /// ����� ������
        /// </summary>
        public string TextAnswer { get; set; }
        /// <summary>
        /// ����� ������������
        /// </summary>
        [NotMapped]
        public int UserAnswer { get; set; }

        /// <summary>
        /// ����� ������������, ������������ �����
        /// </summary>
        [NotMapped]
        public string UserTextAnswer { get; set; }
        
        /// <summary>
        /// ��� �������
        /// </summary>
        public int QuestionType { get; set; }
    }
}