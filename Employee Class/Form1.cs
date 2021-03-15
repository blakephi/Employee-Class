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
            emp2.Name = "Mark Jones";
            emp2.ID = 39119;
            emp2.Department = "IT";
            emp2.Position = "Programmer";

            Employee emp3 = new Employee();
            emp3.Name = "Joy Rogers";
            emp3.ID = 81774;
            emp3.Department = "Manufacturing";
            emp3.Position = "Engineer";

            nameLabel.Text = "1. " + emp1.Name + "\n\n\n\n\n\n2. " + emp2.Name + "\n\n\n\n\n\n3. " + emp3.Name;
            idLabel.Text = "1. " + emp1.ID + "\n\n\n\n\n\n2. " + emp2.ID + "\n\n\n\n\n\n3. " + emp3.ID;
            deptLabel.Text = "1. " + emp1.Department + "\n\n\n\n\n\n2. " + emp2.Department + "\n\n\n\n\n\n3. " + emp3.Department;
            positionLabel.Text = "1. " + emp1.Position + "\n\n\n\n\n\n2. " + emp2.Position + "\n\n\n\n\n\n3. " + emp3.Position;
        }
    }
}
