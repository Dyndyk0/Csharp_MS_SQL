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
    public partial class EditPassenger : Form
    {
        public EditPassenger()
        {
            InitializeComponent();
            Money.Text = Form1.passenger.Money;
            Name.Text = Form1.passenger.Name;
            Surname.Text = Form1.passenger.Surname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.passenger.Money = Money.Text;
            Form1.passenger.Name = Name.Text;
            Form1.passenger.Surname = Surname.Text;

            if (float.TryParse(Form1.passenger.Money, out _))
            {
                Form1.passenger.EditSQL();
            }

            this.Close();
        }
    }
}
