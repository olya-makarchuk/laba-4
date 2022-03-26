using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4s
{
    public abstract class Employee
    {
        public string name;
        public string count_;
        public int salary_;
        public string count_met;
        public int salary_met;
        public string job;

        public Employee(string name, string count_, int salary_)
        {
            this.name = name;
            this.count_ = count_;
            this.salary_ = salary_;
            count_met = Count();
            salary_met = Salary();
            job = Job();

        }

        public void InfoEmp()
        {
            Console.WriteLine($"\n{name} - {job}\nСтаж роботи - {count_met}   Зарплата - {salary_met}");
        }

        public abstract string Count();
        public abstract int Salary();
        public abstract string Job();
    }
}
