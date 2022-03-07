using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz4V
{
    public class Session
    {
        private string Semester;
        public void GetSemester()
        {
            Console.WriteLine(Semester);
        }

        public void SetSemester(string S)
        {
            this.Semester = S;
        }
        private int Test;
        private int Exam;
        public void SetExams(int Test, int Exam)
        {
            this.Test = Test;
            this.Exam = Exam;
        }
        public void CountExam()
        {
            int C = Exam + Test;
            Console.WriteLine("Кол-во экзаменов и зачётов = " + C);
        }
        public void PrintSession()
        {
            Console.WriteLine("Семестр = " + Semester + " |" +
                " Зачётов = " + Test + " |" +
                " Екзаменов = " + Exam + " |");
        }
    }
}
