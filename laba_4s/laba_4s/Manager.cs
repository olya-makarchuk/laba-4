using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4s
{
    public class Manager: Employee
    {
        public Manager(string count_, int salary_, string name) : base(name, count_, salary_) { }
        public override string Count()
        {
            count_met = count_;
            return count_met;
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
