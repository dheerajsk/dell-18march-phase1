using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcepts
{
    class FullTimeEmployee : Employee, IEmployeeBenifits
    {
        public int MonthlySalary { get; set; }
        public FullTimeEmployee(int id, string name, string dept, int monthlySal): base(id, name, dept)
        {
            this.MonthlySalary = monthlySal;
        }

        public void GetBenifit()
        {
           // Logic
        }
    }
}
