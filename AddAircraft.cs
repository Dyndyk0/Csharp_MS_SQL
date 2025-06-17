using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD1
{
    public partial class AddAircraft : Form
    {
        public AddAircraft()
        {
            InitializeComponent();
            Model.Text = Form1.aircraft.Model;
            ProductionDate.Text = Form1.aircraft.ProductionDate;
            MonthlyExpenses.Text = Form1.aircraft.MonthlyExpenses;
            NumberSeats.Text = Form1.aircraft.NumberSeats;

            ProductionDate.Format = DateTimePickerFormat.Custom;
            ProductionDate.CustomFormat = "dd-MM-yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.aircraft.Model = Model.Text;
            Form1.aircraft.ProductionDate = ProductionDate.Text;
            Form1.aircraft.MonthlyExpenses = MonthlyExpenses.Text;
            Form1.aircraft.NumberSeats = NumberSeats.Text;

            if (DateTime.TryParse(Form1.aircraft.ProductionDate, out _) && int.TryParse(Form1.aircraft.NumberSeats, out _) && float.TryParse(Form1.aircraft.NumberSeats, out _))
            {
                Form1.aircraft.EditSQL();
                Close();
            }
        }
    }
}
