using System;
using System.Collections.Generic;

namespace pollService.DataAccess
{
    /// <summary>
    /// �������� �� ����
    /// </summary>
    public class Quiz
    {
        public int Id { get; set; }
        /// <summary>
        /// ��������� �����
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// ������ �� ����
        /// </summary>
        public string Permalink { get; set; }
        /// <summary>
        /// ������ ��������
        /// </summary>
        public ICollection<Question> Questions { get; set; }
    }
}