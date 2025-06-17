using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD1
{
    public partial class EditPilot : Form
    {
        public EditPilot()
        {
            InitializeComponent();
            Name.Text = Form1.pilot.Name;
            Surname.Text = Form1.pilot.Surname;
            FlightHours.Text = Form1.pilot.FlightHours;
            Salary.Text = Form1.pilot.Salary;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.pilot.Name = Name.Text;
            Form1.pilot.Surname = Surname.Text;
            Form1.pilot.FlightHours = FlightHours.Text;
            Form1.pilot.Salary = Salary.Text;

            if (int.TryParse(Form1.pilot.FlightHours, out _) && float.TryParse(Form1.pilot.Salary, out _))
            {
                Form1.pilot.EditSQL();
            }

            this.Close();
        }
    }
}
