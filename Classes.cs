using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BD1
{
    public class Aircraft
    {
        public int ID = -1;
        public string Model;
        public string ProductionDate;
        public string MonthlyExpenses;
        public string NumberSeats;

        public void EditSQL()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            MonthlyExpenses = MonthlyExpenses.Replace(',', '.');
            string sql;
            if (ID == -1)
            {
                sql = "INSERT INTO [BAZA].[dbo].[Aircraft] ([model], [production date], [monthly expenses], [number of seats])" +
                    "VALUES (N'" + Model + "','" + ProductionDate + "'," + MonthlyExpenses + "," + NumberSeats + ")";
            }
            else
            {
                sql = "UPDATE [BAZA].[dbo].[Aircraft] SET [model] = '" + Model + "',[production date] = '" + ProductionDate +
                    "',[monthly expenses] = '" + MonthlyExpenses + "',[number of seats] = " + NumberSeats + " WHERE [Aircraft ID] = " + Convert.ToString(ID);
            }

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    public class Passenger
    {
        public int ID = -1;
        public string Money;
        public string Name;
        public string Surname;

        public void EditSQL()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            Money = Money.Replace(',', '.');

            string sql;
            if (ID == -1)
            {
                sql = "INSERT INTO [BAZA].[dbo].[Passenger] ([money], [name], [surname])" +
                    "VALUES (" + Money + ",N'" + Name + "',N'" + Surname + "')";
            }
            else
            {
                sql = "UPDATE [BAZA].[dbo].[Passenger] SET [money] = " + Money + ", [name] = N'" + Name +
                    "', [surname] = N'" + Surname + "' WHERE [Passenger ID] = " + Convert.ToString(ID);
            }

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    public class Pilot
    {
        public int ID = -1;
        public string Name;
        public string Surname;
        public string FlightHours;
        public string Salary;

        public void EditSQL()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            Salary = Salary.Replace(',', '.');
            string sql;
            if (ID == -1)
            {
                sql = "INSERT INTO [BAZA].[dbo].[Pilot] ([name], [surname], [flight hours], [salary])" +
                    "VALUES (N'" + Name + "',N'" + Surname + "'," + FlightHours + "," + Salary + ")";
            }
            else
            {
                sql = "UPDATE [BAZA].[dbo].[Pilot] SET [name] = N'" + Name + "',[surname] = N'" + Surname +
                    "',[flight hours] = '" + FlightHours + "',[salary] = " + Salary + " WHERE [ID pilot] = " + Convert.ToString(ID);
            }

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    public class Flight
    {
        public int ID = -1;
        public string AircraftID;
        public string PilotID;
        public string PlaceOfDeparture;
        public string LandingPlace;
        public string DepartureDate;
        public string LandingDate;

        public void EditSQL()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string sql;
            if (ID == -1)
            {
                sql = "INSERT INTO [BAZA].[dbo].[Flight] ([Aircraft ID], [pilot ID], [place of departure], [landing place], [departure date], [landing date])" +
                    "VALUES (" + AircraftID + "," + PilotID + ",N'" + PlaceOfDeparture + "',N'" + LandingPlace + "','" + DepartureDate + "','" + LandingDate + "')";
            }
            else
            {
                sql = "UPDATE [BAZA].[dbo].[Flight] SET [Aircraft ID] = " + AircraftID + ",[pilot ID] = " + PilotID + ",[place of departure] = N'" +
                    PlaceOfDeparture + "',[landing place] = N'" + LandingPlace + "',[departure date] = '" + DepartureDate + "',[landing date] = '" + LandingDate +
                    "' WHERE [Flight ID] = " + Convert.ToString(ID);
            }

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    public class Ticket
    {
        public int ID = -1;
        public string FlightID;
        public string PassengerID;
        public string TicketPrice;
        public string TicketType;
        public string Seat;

        public void EditSQL()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            TicketPrice = TicketPrice.Replace(',', '.');
            string sql;
            if (ID == -1)
            {
                sql = "exec Sell_Ticket " + FlightID + "," + PassengerID + "," + TicketPrice + ",N'" + TicketType + "'," + Seat;
            }
            else
            {
                sql = "UPDATE [BAZA].[dbo].[Ticket] SET [Flight ID] = " + FlightID + ",[Passenger ID] = " + PassengerID + ",[ticket price] = " +
                    TicketPrice + ",[ticket type] = N'" + TicketType + "',[seat] = " + Seat + " WHERE [Ticket ID] = " + Convert.ToString(ID);
            }

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }   
}
