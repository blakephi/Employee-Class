using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Susan Meyers";
            emp1.ID = 47899;
            emp1.Department = "Accounting";
            emp1.Position = "Vice President";

            Employee emp2 = new Employee();
            emp1.Name = "Mark Jones";
            emp1.ID = 39119;
            emp1.Department = "IT";
            emp1.Position = "Programmer";

            Employee emp3 = new Employee();
            emp1.Name = "Joy Rogers";
            emp1.ID = 81774;
            emp1.Department = "Manufacturing";
            emp1.Position = "Engineer";


        }
    }
}
