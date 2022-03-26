using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4s
{
    public class Engineer: Employee
    {
        public static int num = 0;
        public int week;
        public Engineer(string count_, int salary_, string name, int week) : base(name, count_, salary_)
        {
            this.week = week;
        }

        public override string Count()
        {
            num++;
            count_met = count_;
            return count_met;
        }
        public static int Num()
        {
            return num;
        }

        public override int Salary()
        {
            salary_met = salary_;
            return salary_met;
        }
        public override string Job()
        {
            job = GetType().Name;
            return job;
        }
        public void Info()
        {
            Console.WriteLine($"Кiлькiсть вихiдних у роцi - {week}");
        }
    }
}
