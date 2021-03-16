using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
    class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public Employee(string Name, int ID, string Department, string Pposition)
        {
            this.Name = Name;
            this.ID = ID;
            this.Department = Department;
            this.Position = Position;
        }

        public Employee(string name, int idNumber)
        {
            this.Name = Name;
            this.ID = ID;
            this.Department = "";
            this.Position = "";
        }

        public Employee()
        {
            this.Name = "";
            this.ID = 0;
            this.Department = "";
            this.Position = "";
        }
    }
}
