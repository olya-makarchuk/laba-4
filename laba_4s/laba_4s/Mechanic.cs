using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4s
{
    public class Mechanic: Employee
    {
        public static int num=0;
        public Mechanic(string count_, int salary_, string name): base(name,count_,salary_) { }

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
        
    }
}
