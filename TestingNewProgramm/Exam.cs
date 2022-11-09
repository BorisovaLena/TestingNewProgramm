using System;
using System.Collections.Generic;
using System.Text;

namespace TestingNewProgramm
{
    class Exam : Module
    {
        public string titleOfTheDiscipline;//название дисциплины
        public int numberOfFives;//количество пятерок за экзамен
        public int numberOfFours;//количество четверок за экзамен
        public int numberOfThrees;//количество троек за экзамен
        public int numberOfTwos;//количество двоек за экзамен
        public double numberOfExamTakers;//количество студентов, сдавших экзамен
        public Exam(string titleOfTheDiscipline)
        {
            this.titleOfTheDiscipline = titleOfTheDiscipline;
        }
        public override void ShowTitle()//выводи название дисциплины, по которому был экзамен
        {
            Console.WriteLine("Вы сдаете экзамен по дисциплине " + titleOfTheDiscipline);
        }
        public override double CalculatingTheAverageScore()//подсчет среднего балла
        {
            numberOfExamTakers = (5 * numberOfFives + 4 * numberOfFours + 3 * numberOfThrees + 2 * numberOfTwos) / (numberOfFives + numberOfFours + numberOfThrees + numberOfTwos);
            return numberOfExamTakers;
        }
        public override void PrintAveradeScore()//вывод среднего балла
        {
            Console.WriteLine("Средний балл группы: " + numberOfExamTakers);

        }
    }
}
