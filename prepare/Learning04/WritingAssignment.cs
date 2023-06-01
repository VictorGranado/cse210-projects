using System;

namespace Learning04
{
    class WritingAssignment : Assignment
    {
        private string _title;

        public WritingAssignment(string studentName, string topic, string title)
            : base(studentName, topic)
        {
            _title = title;
        }

        public string GetWritingInformation()
        {
            string studentName = GetStudentName();
            return $"The {_title} by {studentName}";
        }
    }
}