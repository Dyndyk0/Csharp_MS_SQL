using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD1
{
    public partial class EditTicket : Form
    {
        public EditTicket()
        {
            InitializeComponent();


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            conn.Open();

            String sql = "SELECT [Flight ID] as FlightID, [place of departure] as PlaceOfDeparture, " +
                "[landing place] as LandingPlace, [departure date] as DepartureDate FROM [BAZA].[dbo].[Flight]";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dt.Columns.Add("DataFlight", typeof(string), "PlaceOfDeparture+'-'+LandingPlace+' '+DepartureDate");
            FlightID.DropDownStyle = ComboBoxStyle.DropDownList;
            FlightID.DataSource = dt;
            FlightID.DisplayMember = "DataFlight";
            FlightID.ValueMember = "FlightID";

            sql = "SELECT [Passenger ID] as PassengerID, [name], [surname] FROM[BAZA].[dbo].[Passenger]";
            dt = new DataTable();
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dt.Columns.Add("DataPassenger", typeof(string), "name+' '+surname");
            PassengerID.DropDownStyle = ComboBoxStyle.DropDownList;
            PassengerID.DataSource = dt;
            PassengerID.DisplayMember = "DataPassenger";
            PassengerID.ValueMember = "PassengerID";

            conn.Close();
            if ((Form1.ticket.FlightID != null) && (Form1.ticket.PassengerID != null))
            {
                FlightID.SelectedValue = Form1.ticket.FlightID;
                PassengerID.SelectedValue = Form1.ticket.PassengerID;
                TicketPrice.Text = Form1.ticket.TicketPrice;
                TicketType.Text = Form1.ticket.TicketType;
                Seat.Text = Form1.ticket.Seat;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ticket.FlightID = FlightID.SelectedValue.ToString();
            Form1.ticket.PassengerID = PassengerID.SelectedValue.ToString();
            Form1.ticket.TicketPrice = TicketPrice.Text;
            Form1.ticket.TicketType = TicketType.Text;
            Form1.ticket.Seat = Seat.Text;

            int St = 0;
            float Price = 0;
            bool i = float.TryParse(Form1.ticket.TicketPrice, out Price);
            bool i1 = int.TryParse(Form1.ticket.Seat, out St);
            if ((Form1.ticket.TicketPrice != "") && float.TryParse(Form1.ticket.TicketPrice, out Price) && int.TryParse(Form1.ticket.Seat, out St))
            {
                if ((St > 0) && (Price > 1000))
                {
                    Form1.ticket.EditSQL();

                    this.Close();
                }
            }
        }
    }
}
