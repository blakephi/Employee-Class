using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
    class Employee
    {
        public string empName;
        public int empID;
        public string empDept;
        public string empPosition;

        public string Name { get; set; }
        public int ID { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public Employee(string name, int idNumber, string department, string position)
        {
            empName = Name;
            empID = ID;
            empDept = Department;
            empPosition = Position;
        }

        public Employee(string name, int idNumber)
        {
            empName = Name;
            empID = ID;
            empDept = "";
            empPosition = "";
        }

        public Employee()
        {
            empName = "";
            empID = 0;
            empDept = "";
            empPosition = "";
        }
    }
}
