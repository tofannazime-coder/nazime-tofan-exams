using System;

namespace Odev05_GradeBook.Models
{
    public class GradeBook
    {
        public string StudentName { get; set; }
        public int ExamCount { get; private set; }
        public int TotalScore { get; private set; }

        public GradeBook(string studentName)
        {
            StudentName = studentName;
        }

        public void AddExamScore(int score)
        {
            if (score < 0 || score > 100)
            {
                throw new ArgumentOutOfRangeException("Girilen puan 0 ile 100 arasında olmalıdır.");
            }

            TotalScore += score;
            ExamCount++;
        }
        public double GetAverageScore()
        {
            if (ExamCount == 0)
            {
                throw new InvalidOperationException("Henüz sınav puanı eklenmedi.");
            }

            return (double)TotalScore / ExamCount;
        }

    }
}