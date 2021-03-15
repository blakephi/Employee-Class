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

        public Employee(string name, int idNumber, string department, string position)
        {
            empName = name;
            empID = idNumber;
            empDept = department;
            empPosition = position;
        }

        public Employee(string name, int idNumber)
        {
            empName = name;
            empID = idNumber;
            empDept = "";
            empPosition = "";
        }

        public Employee()
        {

        }
    }
}
