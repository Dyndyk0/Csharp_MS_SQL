using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BD1
{
    public partial class EditFlight : Form
    {
        public EditFlight()
        {
            InitializeComponent();

            DepartureDate.Format = DateTimePickerFormat.Custom;
            DepartureDate.CustomFormat = "dd-MM-yyyy HH:mm:ss";

            LandingDate.Format = DateTimePickerFormat.Custom;
            LandingDate.CustomFormat = "dd-MM-yyyy HH:mm:ss";


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            conn.Open();

            String sql = "SELECT [Aircraft ID], [model] FROM [BAZA].[dbo].[Aircraft]";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            AircraftID.DropDownStyle = ComboBoxStyle.DropDownList;
            AircraftID.DataSource = dt;
            AircraftID.DisplayMember = "model";
            AircraftID.ValueMember = "Aircraft ID";

            sql = "SELECT [ID Pilot], [name], [surname] FROM[BAZA].[dbo].[Pilot]";
            dt = new DataTable();
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            dt.Columns.Add("FI", typeof(string), "name+' '+surname");
            PilotID.DropDownStyle = ComboBoxStyle.DropDownList;
            PilotID.DataSource = dt;
            PilotID.DisplayMember = "FI";
            PilotID.ValueMember = "ID Pilot";
            if ((Form1.flight.AircraftID != null) && (Form1.flight.PilotID != null))
            {
                AircraftID.SelectedValue = Form1.flight.AircraftID;
                PilotID.SelectedValue = Form1.flight.PilotID;
                PlaceOfDeparture.Text = Form1.flight.PlaceOfDeparture;
                LandingPlace.Text = Form1.flight.LandingPlace;
                DepartureDate.Text = Form1.flight.DepartureDate;
                LandingDate.Text = Form1.flight.LandingDate;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.flight.AircraftID = AircraftID.SelectedValue.ToString();
            Form1.flight.PilotID = PilotID.SelectedValue.ToString();
            Form1.flight.PlaceOfDeparture = PlaceOfDeparture.Text;
            Form1.flight.LandingPlace = LandingPlace.Text;
            Form1.flight.DepartureDate = DepartureDate.Text;
            Form1.flight.LandingDate = LandingDate.Text;

            if ((Form1.flight.PlaceOfDeparture != "") && (Form1.flight.LandingPlace != ""))
            {
                Form1.flight.EditSQL();
            }

            this.Close();
        }
    }
}
