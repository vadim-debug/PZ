using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz4V
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Session first = new Session();

            first.SetExams(2, 6);
            first.SetSemester("Первый");
            first.PrintSession();

            Session second = new Session();
            second.SetSemester("второй");
            second.GetSemester();
            second.SetExams(7, 2);
            second.CountExam();
            Console.ReadLine();
        }
    }
}
