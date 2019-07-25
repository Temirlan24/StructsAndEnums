using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    public struct Employee
    {
        public string Name { get; set; }
        public Vacancies Vacancy { get; set; }
        public int Salary { get; set; }
        public int[] EnterDate { get; set; }
    }
}
