using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace pollService.DataAccess
{
    /// <summary>
    /// ������� ������
    /// </summary>
    public class AnswerOption
    {
        public int Id { get; set; }
        /// <summary>
        /// ��������� ��������
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// ������������ ��������
        /// </summary>
        public bool Correct { get; set; }

        /// <summary>
        /// ������� ����, ��� ������������ ������ �������
        /// </summary>
        [NotMapped]
        public bool Checked { get; set; }
    }
}