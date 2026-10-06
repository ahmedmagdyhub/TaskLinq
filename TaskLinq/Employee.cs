using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLinq
{
    public class Employee
    {
        public Employee(int Id ,string Name ,decimal Salary)
        {
        this.id = Id;   
            this.name = Name;
            this.salary = Salary;

        }
        public  int  id { get; set; }
        public  string  name { get; set; }
        public decimal salary { get; set; }
    }
}
