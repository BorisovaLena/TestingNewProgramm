using System;
using System.Collections.Generic;
using System.Text;

namespace TestingNewProgramm
{
    abstract class Module
    {
        public abstract void ShowTitle();//вывод названия
        public abstract double CalculatingTheAverageScore();//подсчет среднего балла
        public abstract void PrintAveradeScore();//вывод среднего балла
    }
}
