using System;

namespace TestingNewProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название дисциплины");
            string titleOfTheDiscipline = Console.ReadLine();
            Exam A = new Exam(titleOfTheDiscipline);
            A.ShowTitle();
            Console.WriteLine("Введите количество пятерок: ");
            A.numberOfFives = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество четверок: ");
            A.numberOfFours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество троек: ");
            A.numberOfThrees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество двоек: ");
            A.numberOfTwos = Convert.ToInt32(Console.ReadLine());
            A.PrintAveradeScore();
            Console.WriteLine("Введите название предмета");
            string titleSchoolSubject = Console.ReadLine();
            ControlWork B = new ControlWork(titleSchoolSubject);
            B.ShowTitle();
            B.ShowTheNumberOfStudent();
            Console.WriteLine("Введите вашу первую оценку за контрольную работу: ");
            B.firstAssessment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вашу вторую оценку за контрольную работу: ");
            B.secondAssessment = Convert.ToInt32(Console.ReadLine());
            B.ShowTheFinalAssessment();
        }
    }
}
