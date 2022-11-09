using System;
using System.Collections.Generic;
using System.Text;

namespace TestingNewProgramm
{
    class ControlWork : Exam
    {
        public string titleSchoolSubject;//название предмета
        public int firstAssessment;//первая оценка студента за контрольную работу
        public int secondAssessment;//вторая оценка студента за контрольную работу
        public double finalAssessment;//итоговая оценка студента за контрольную работу
        public ControlWork(string titleSchoolSubject) : base(titleSchoolSubject)
        {
            this.titleSchoolSubject = titleSchoolSubject;
        }
        public override void ShowTitle()//выводи название дисциплины, по которому была контрольная работа
        {
            Console.WriteLine("Вы пишете контрольную работу по " + titleSchoolSubject);
        }
        new public void ShowTheNumberOfStudent()//вывод количества студентов, которые написали контрольную работу
        {
            base.PrintAveradeScore();
            Console.WriteLine("Написали контрольную работу " + CalculatingTheNumberOfStudent() + " студентов");
        }
        public double CalculatingTheNumberOfStudent()//подсчет количесва студентов, которые написали контрольную работу
        {
            return numberOfFives + numberOfFours + numberOfThrees + numberOfTwos;
        }
        public void ShowTheFinalAssessment()// вывод итоговой оценки за контрольную работу
        {
            finalAssessment = (firstAssessment + secondAssessment) / 2;
            Console.WriteLine("Ваш балл: " + finalAssessment);
        }
    }
}
