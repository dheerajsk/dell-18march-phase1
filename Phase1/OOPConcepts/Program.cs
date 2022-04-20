using System;

namespace OOPConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee emp1 = new FullTimeEmployee(1, "Jon Doe", "Finance", 50000);
            emp1.GetSalary();
        }
    }
}
