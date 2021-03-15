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
            Employee emp2 = new Employee();
            Employee epm3 = new Employee();

            emp1.empName = "Susan Meyers";
            emp1.empID = 47899;
            emp1.empDept = "Accounting";
            emp1.empPosition = "Vice President";


        }
    }
}
