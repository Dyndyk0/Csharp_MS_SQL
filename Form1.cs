using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml;
using System.Reflection;
using System.Collections.Generic;

namespace BD1
{
    public partial class Form1 : Form
    {
        public string[] sorted = new string[5];
        public string[] filter = new string[5];
        public List<string> selectedFlightID = new List<string>();
        public DataTable GetSQLTable(string NameTable, int NumberFilter)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            conn.Open();
            String sql = "Select * from [" + NameTable + "]" + filter[NumberFilter] + sorted[NumberFilter];
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();
            return dt;
        }
        public void RefreshDgvAircraft()
        {
            DgvAircraft.DataSource = GetSQLTable("aircraft", 0);
            DgvAircraft.Columns[1].HeaderText = "Модель";
            DgvAircraft.Columns[2].HeaderText = "Дата производства";
            DgvAircraft.Columns[3].HeaderText = "Гусь";
            DgvAircraft.Columns[4].HeaderText = "Места";

            DgvAircraft.ReadOnly = true;
            DgvAircraft.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in DgvAircraft.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DgvAircraft.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void RefreshDgvPassenger()
        {
            DgvPassenger.DataSource = GetSQLTable("Passenger", 2);
            DgvPassenger.Columns[1].HeaderText = "Деньги";
            DgvPassenger.Columns[2].HeaderText = "Имя";
            DgvPassenger.Columns[3].HeaderText = "Фамилия";

            DgvPassenger.ReadOnly = true;
            DgvPassenger.AllowUserToAddRows = false;
            //foreach (DataGridViewColumn column in DgvPassenger.Columns)
            //{
            //    column.SortMode = DataGridViewColumnSortMode.NotSortable;
            //}
            DgvPassenger.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void RefreshDgvPilot()
        {
            DgvPilot.DataSource = GetSQLTable("Pilot", 1);
            DgvPilot.Columns[1].HeaderText = "Имя";
            DgvPilot.Columns[2].HeaderText = "Фамилия";
            DgvPilot.Columns[3].HeaderText = "Лётные часы";
            DgvPilot.Columns[4].HeaderText = "Запрлата";

            DgvPilot.ReadOnly = true;
            DgvPilot.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in DgvPilot.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DgvPilot.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void RefreshDgvFlight()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            conn.Open();
            String sql =    "SELECT[Flight ID],[BAZA].[dbo].[Flight].[Aircraft ID], [pilot ID], [BAZA].[dbo].[aircraft].model," +
                            "[BAZA].[dbo].[Pilot].[name], [place of departure], [landing place], [departure date], [landing date] FROM [BAZA].[dbo].[Flight]" +
                            "JOIN[BAZA].[dbo].[aircraft] on [BAZA].[dbo].[Flight].[Aircraft ID] = [BAZA].[dbo].[aircraft].[Aircraft ID]" +
                            "JOIN[BAZA].[dbo].[Pilot] on [BAZA].[dbo].[Flight].[Pilot ID] = [BAZA].[dbo].[Pilot].[ID Pilot]" + filter[3];
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();

            DgvFlight.DataSource = dt;
            DgvFlight.Columns[3].HeaderText = "Модель самолёта";
            DgvFlight.Columns[4].HeaderText = "Имя пилота";
            DgvFlight.Columns[5].HeaderText = "Место вылета";
            DgvFlight.Columns[6].HeaderText = "Место посадки";
            DgvFlight.Columns[7].HeaderText = "Время вылета";
            DgvFlight.Columns[8].HeaderText = "Время посадки";

            DgvFlight.ReadOnly = true;
            DgvFlight.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in DgvFlight.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DgvFlight.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void RefreshDgvTicket()
        {
            //string SQLfilter = " WHERE [model] = '" + DgvFlight.SelectedRows[0].Cells[0].Value.ToString() + "'";
            string SQLFilterFlightID = " WHERE";
            if (selectedFlightID.Count > 0)
            {
                SQLFilterFlightID = SQLFilterFlightID + " ([ticket].[Flight ID] = " + selectedFlightID[0] + ")";
                for (int indexElement = 1; indexElement < selectedFlightID.Count; indexElement++)
                {
                    SQLFilterFlightID = SQLFilterFlightID + " or ([ticket].[Flight ID] = " + selectedFlightID[indexElement] + ")";
                }
            }
            if ((selectedFlightID.Count == 0) && (filter[4] == null))
            {
                SQLFilterFlightID = SQLFilterFlightID + " ([ticket ID] > -1)";
            }

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            conn.Open();
            String sql = "SELECT [ticket ID],[ticket].[Flight ID], [ticket].[Passenger ID], [passenger].[name]," +
                         "[Flight].[departure date], [Flight].[place of departure]," +
                         "[Flight].[landing place], [ticket price],[ticket type],[seat] FROM[ticket]" +
                         "JOIN[Flight] ON[ticket].[Flight ID] = [Flight].[Flight ID]" +
                         "JOIN[passenger] ON[ticket].[passenger id] = [passenger].[passenger id]" + SQLFilterFlightID;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();

            DgvTicket.DataSource = dt;
            DgvTicket.Columns[3].HeaderText = "Имя пассажира";
            DgvTicket.Columns[4].HeaderText = "Дата вылета";
            DgvTicket.Columns[5].HeaderText = "От куда";
            DgvTicket.Columns[6].HeaderText = "Куда";
            DgvTicket.Columns[7].HeaderText = "Цена билета";
            DgvTicket.Columns[8].HeaderText = "Тип балета";
            DgvTicket.Columns[9].HeaderText = "Место";

            DgvTicket.ReadOnly = true;
            DgvTicket.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in DgvTicket.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DgvTicket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public Form1()
        {
            InitializeComponent();
            RefreshDgvAircraft();
            RefreshDgvPassenger();
            RefreshDgvPilot();
            RefreshDgvFlight();
            RefreshDgvTicket();

            DgvAircraft.Columns[0].Visible = false;
            DgvPassenger.Columns[0].Visible = false;
            DgvPilot.Columns[0].Visible = false;
            DgvFlight.Columns[0].Visible = false;
            DgvFlight.Columns[1].Visible = false;
            DgvFlight.Columns[2].Visible = false;
            DgvTicket.Columns[0].Visible = false;
            DgvTicket.Columns[1].Visible = false;
            DgvTicket.Columns[2].Visible = false;
            IDview.Visible = false;

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu Menu = new ContextMenu();
                if (IDview.Visible == false)
                {
                    Menu.MenuItems.Add("Открыть открыватель ID", new EventHandler(IdViewOn));
                }
                else
                {
                    Menu.MenuItems.Add("Скрыть открыватель ID", new EventHandler(IdViewOff));
                }
                Menu.Show(this, new Point(e.X, e.Y));
            }
        } 
        private void IdViewOn(object sender, EventArgs e)
        {
            IDview.Visible = true;
        }
        private void IdViewOff(object sender, EventArgs e)
        {
            IDview.Visible = false;
        }

        private void IDview_CheckedChanged(object sender, EventArgs e)
        {
            if (IDview.Checked)
            {
                DgvAircraft.Columns[0].Visible = true;
                DgvPassenger.Columns[0].Visible = true;
                DgvPilot.Columns[0].Visible = true;
                DgvFlight.Columns[0].Visible = true;
                DgvFlight.Columns[1].Visible = true;
                DgvFlight.Columns[2].Visible = true;
                DgvTicket.Columns[0].Visible = true;
                DgvTicket.Columns[1].Visible = true;
                DgvTicket.Columns[2].Visible = true;
            }
            else
            {
                DgvAircraft.Columns[0].Visible = false;
                DgvPassenger.Columns[0].Visible = false;
                DgvPilot.Columns[0].Visible = false;
                DgvFlight.Columns[0].Visible = false;
                DgvFlight.Columns[1].Visible = false;
                DgvFlight.Columns[2].Visible = false;
                DgvTicket.Columns[0].Visible = false;
                DgvTicket.Columns[1].Visible = false;
                DgvTicket.Columns[2].Visible = false;
            }
        } // Показыватель ID

        private void button1_Click(object sender, EventArgs e) // отчётик
        {
            Report report = new Report();
            report.ShowDialog();
        }


        public static Aircraft aircraft = new Aircraft();
        private void DgvAircraft_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (DgvAircraft.HitTest(e.X, e.Y).RowIndex > -1)
                {
                    DgvAircraft.CurrentCell = DgvAircraft[DgvAircraft.HitTest(e.X, e.Y).ColumnIndex, DgvAircraft.HitTest(e.X, e.Y).RowIndex];
                }

                ContextMenu Menu = new ContextMenu();
                Menu.MenuItems.Add("Редактировать", new EventHandler(DgvAircraftEdit));
                Menu.MenuItems.Add("Добавть", new EventHandler(DgvAircraftAdd));
                Menu.MenuItems.Add("Удалить", new EventHandler(DgvAircraftDelete));
                if (DgvAircraft.HitTest(e.X, e.Y).ColumnIndex == 1)
                {
                    if (filter[0] == null)
                    {
                        Menu.MenuItems.Add("Фильтровать по ячейке", new EventHandler(DgvAircraftFilterOn));
                    }
                    else
                    {
                        Menu.MenuItems.Add("Снять фильтрацию", new EventHandler(DgvAircraftFilterOff));
                    }
                } // Фильтрация
                if (DgvAircraft.HitTest(e.X, e.Y).ColumnIndex == 4)
                {
                    if (sorted[0] == null)
                    {
                        Menu.MenuItems.Add("Сортировать по ячейке", new EventHandler(DgvTicketSortedOn));
                    }
                    else
                    {
                        Menu.MenuItems.Add("Снять сортировку", new EventHandler(DgvTicketSortedOff));
                    }
                } // сортировка

                Menu.Show(DgvAircraft, new Point(e.X, e.Y));
            }
        } // Самолётики
        private void DgvAircraftEdit(object sender, EventArgs e)
        {
            if (DgvAircraft.CurrentCell.RowIndex != -1)
            {
                Form1.aircraft.ID = Convert.ToInt32(DgvAircraft.Rows[DgvAircraft.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Form1.aircraft.Model = DgvAircraft.Rows[DgvAircraft.CurrentCell.RowIndex].Cells[1].Value.ToString();
                Form1.aircraft.ProductionDate = DgvAircraft.Rows[DgvAircraft.CurrentCell.RowIndex].Cells[2].Value.ToString();
                Form1.aircraft.MonthlyExpenses = DgvAircraft.Rows[DgvAircraft.CurrentCell.RowIndex].Cells[3].Value.ToString();
                Form1.aircraft.NumberSeats = DgvAircraft.Rows[DgvAircraft.CurrentCell.RowIndex].Cells[4].Value.ToString();

                AddAircraft addAircraft = new AddAircraft();
                addAircraft.ShowDialog();

                RefreshDgvAircraft();
                Form1.aircraft = new Aircraft();
            }
        }
        private void DgvAircraftAdd(object sender, EventArgs e)
        {
            Form1.aircraft.ID = -1;
            AddAircraft addAircraft = new AddAircraft();
            addAircraft.ShowDialog();

            RefreshDgvAircraft();
            Form1.aircraft = new Aircraft();
        }
        private void DgvAircraftDelete(object sender, EventArgs e)
        {
            if (DgvAircraft.CurrentCell.RowIndex != -1)
            {
                Form1.aircraft.ID = Convert.ToInt32(DgvAircraft.Rows[DgvAircraft.CurrentCell.RowIndex].Cells[0].Value.ToString());

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                string sql = "DELETE FROM [BAZA].[dbo].[aircraft] WHERE [Aircraft ID] = " + Convert.ToString(Form1.aircraft.ID);

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                RefreshDgvAircraft();
                Form1.aircraft = new Aircraft();
            }
        }
        private void DgvAircraftFilterOn(object sender, EventArgs e)
        {
            filter[0] = " WHERE [model] = '" + DgvAircraft.Rows[DgvAircraft.CurrentCell.RowIndex].Cells[1].Value.ToString() + "'";
            RefreshDgvAircraft();
        }
        private void DgvAircraftFilterOff(object sender, EventArgs e)
        {
            filter[0] = null;
            RefreshDgvAircraft();
        }
        private void DgvTicketSortedOn(object sender, EventArgs e)
        {
            sorted[0] = "ORDER BY [number of seats]";
            RefreshDgvAircraft();
        }
        private void DgvTicketSortedOff(object sender, EventArgs e)
        {
            sorted[0] = null;
            RefreshDgvAircraft();
        }


        public static Pilot pilot = new Pilot();
        private void DgvPilot_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (DgvPilot.HitTest(e.X, e.Y).RowIndex > -1)
                {
                    DgvPilot.CurrentCell = DgvPilot[DgvPilot.HitTest(e.X, e.Y).ColumnIndex, DgvPilot.HitTest(e.X, e.Y).RowIndex];
                }

                ContextMenu Menu = new ContextMenu();
                Menu.MenuItems.Add("Редактировать", new EventHandler(DgvPilotEdit));
                Menu.MenuItems.Add("Добавть", new EventHandler(DgvPilotAdd));
                Menu.MenuItems.Add("Удалить", new EventHandler(DgvPilotDelete));
                if (DgvPilot.HitTest(e.X, e.Y).ColumnIndex == 1)
                {
                    if (filter[1] == null)
                    {
                        Menu.MenuItems.Add("Фильтровать по ячейке", new EventHandler(DgvPilotFilterOn));
                    }
                    else
                    {
                        Menu.MenuItems.Add("Снять фильтрацию", new EventHandler(DgvPilotFilterOff));
                    }
                } // Фильтрация

                Menu.Show(DgvPilot, new Point(e.X, e.Y));
            }
        } // Пилотики
        private void DgvPilotEdit(object sender, EventArgs e)
        {
            if (DgvPilot.CurrentCell.RowIndex != -1)
            {
                Form1.pilot.ID = Convert.ToInt32(DgvPilot.Rows[DgvPilot.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Form1.pilot.Name = DgvPilot.Rows[DgvPilot.CurrentCell.RowIndex].Cells[1].Value.ToString();
                Form1.pilot.Surname = DgvPilot.Rows[DgvPilot.CurrentCell.RowIndex].Cells[2].Value.ToString();
                Form1.pilot.FlightHours = DgvPilot.Rows[DgvPilot.CurrentCell.RowIndex].Cells[3].Value.ToString();
                Form1.pilot.Salary = DgvPilot.Rows[DgvPilot.CurrentCell.RowIndex].Cells[4].Value.ToString();
                
                EditPilot editPilot = new EditPilot();
                editPilot.ShowDialog();

                RefreshDgvPilot();
                Form1.pilot = new Pilot();
            }
        }
        private void DgvPilotAdd(object sender, EventArgs e)
        {
            EditPilot editPilot = new EditPilot();
            editPilot.ShowDialog();

            RefreshDgvPilot();
            Form1.pilot = new Pilot();
        }
        private void DgvPilotDelete(object sender, EventArgs e)
        {
            if (DgvPilot.CurrentCell.RowIndex != -1)
            {
                Form1.pilot.ID = Convert.ToInt32(DgvPilot.Rows[DgvPilot.CurrentCell.RowIndex].Cells[0].Value.ToString());

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                string sql = "DELETE FROM [BAZA].[dbo].[pilot] WHERE [ID pilot] = " + Convert.ToString(Form1.pilot.ID);

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                RefreshDgvPilot();
                Form1.pilot = new Pilot();
            }
        }
        private void DgvPilotFilterOn(object sender, EventArgs e)
        {
            filter[1] = " WHERE [name] = N'" + DgvPilot.Rows[DgvPilot.CurrentCell.RowIndex].Cells[1].Value.ToString() + "'";
            RefreshDgvPilot();
        }
        private void DgvPilotFilterOff(object sender, EventArgs e)
        {
            filter[1] = null;
            RefreshDgvPilot();
        }


        public static Passenger passenger = new Passenger();
        private void DgvPassenger_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (DgvPassenger.HitTest(e.X, e.Y).RowIndex > -1)
                {
                    DgvPassenger.CurrentCell = DgvPassenger[DgvPassenger.HitTest(e.X, e.Y).ColumnIndex, DgvPassenger.HitTest(e.X, e.Y).RowIndex];
                }

                ContextMenu Menu = new ContextMenu();
                Menu.MenuItems.Add("Редактировать", new EventHandler(DgvPassengerEdit));
                Menu.MenuItems.Add("Добавть", new EventHandler(DgvPassengerAdd));
                Menu.MenuItems.Add("Удалить", new EventHandler(DgvPassengerDelete));
                if (DgvPilot.HitTest(e.X, e.Y).ColumnIndex == 2)
                {
                    if (filter[2] == null)
                    {
                        Menu.MenuItems.Add("Фильтровать по ячейке", new EventHandler(DgvPassengerFilterOn));
                    }
                    else
                    {
                        Menu.MenuItems.Add("Снять фильтрацию", new EventHandler(DgvPassengerFilterOff));
                    }
                } // Фильтрация

                Menu.Show(DgvPassenger, new Point(e.X, e.Y));
            }
        } // Пассажирики
        private void DgvPassengerEdit(object sender, EventArgs e)
        {
            if (DgvPassenger.CurrentCell.RowIndex != -1)
            {
                Form1.passenger.ID = Convert.ToInt32(DgvPassenger.Rows[DgvPassenger.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Form1.passenger.Money = DgvPassenger.Rows[DgvPassenger.CurrentCell.RowIndex].Cells[1].Value.ToString();
                Form1.passenger.Name = DgvPassenger.Rows[DgvPassenger.CurrentCell.RowIndex].Cells[2].Value.ToString();
                Form1.passenger.Surname = DgvPassenger.Rows[DgvPassenger.CurrentCell.RowIndex].Cells[3].Value.ToString();

                EditPassenger editPassenger = new EditPassenger();
                editPassenger.ShowDialog();

                RefreshDgvPassenger();
                Form1.passenger = new Passenger();
            }
        }
        private void DgvPassengerAdd(object sender, EventArgs e)
        {
            EditPassenger editPassenger = new EditPassenger();
            editPassenger.ShowDialog();

            RefreshDgvPassenger();
            Form1.passenger = new Passenger();
        }
        private void DgvPassengerDelete(object sender, EventArgs e)
        {
            if (DgvPassenger.CurrentCell.RowIndex != -1)
            {
                Form1.passenger.ID = Convert.ToInt32(DgvPassenger.Rows[DgvPassenger.CurrentCell.RowIndex].Cells[0].Value.ToString());

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                string sql = "DELETE FROM [BAZA].[dbo].[Passenger] WHERE [Passenger ID] = " + Convert.ToString(Form1.passenger.ID);

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                RefreshDgvPassenger();
                Form1.passenger = new Passenger();
            }
        }
        private void DgvPassengerFilterOn(object sender, EventArgs e)
        {
            filter[2] = " WHERE [name] = N'" + DgvPassenger.Rows[DgvPassenger.CurrentCell.RowIndex].Cells[2].Value.ToString() + "'";
            RefreshDgvPassenger();
        }
        private void DgvPassengerFilterOff(object sender, EventArgs e)
        {
            filter[2] = null;
            RefreshDgvPassenger();
        }
        

        public static Flight flight = new Flight();
        private void DgvFlight_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (DgvFlight.HitTest(e.X, e.Y).RowIndex > -1)
                {
                    DgvFlight.CurrentCell = DgvFlight[DgvFlight.HitTest(e.X, e.Y).ColumnIndex, DgvFlight.HitTest(e.X, e.Y).RowIndex];
                }

                ContextMenu Menu = new ContextMenu();
                Menu.MenuItems.Add("Редактировать", new EventHandler(DgvFlightEdit));
                Menu.MenuItems.Add("Добавть", new EventHandler(DgvFlightAdd));
                Menu.MenuItems.Add("Удалить", new EventHandler(DgvFlightDelete));
                if (DgvFlight.HitTest(e.X, e.Y).ColumnIndex == 5)
                {
                    if (filter[3] == null)
                    {
                        Menu.MenuItems.Add("Фильтровать по ячейке", new EventHandler(DgvFlightFilterOn));
                    }
                    else
                    {
                        Menu.MenuItems.Add("Снять фильтрацию", new EventHandler(DgvFlightFilterOff));
                    }
                } // Фильтрация

                Menu.Show(DgvFlight, new Point(e.X, e.Y));
            }
        } // Полётики
        private void DgvFlight_MouseUp(object sender, MouseEventArgs e)
        {
            selectedFlightID = new List<string>();
            for (int i = 0; i < DgvFlight.SelectedRows.Count; i++)
            {
                selectedFlightID.Add(DgvFlight.SelectedRows[i].Cells[0].Value.ToString());
            }
            RefreshDgvTicket();

        }
        private void DgvFlightEdit(object sender, EventArgs e)
        {
            if (DgvFlight.CurrentCell.RowIndex != -1)
            {
                Form1.flight.ID = Convert.ToInt32(DgvFlight.Rows[DgvFlight.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Form1.flight.AircraftID = DgvFlight.Rows[DgvFlight.CurrentCell.RowIndex].Cells[1].Value.ToString();
                Form1.flight.PilotID = DgvFlight.Rows[DgvFlight.CurrentCell.RowIndex].Cells[2].Value.ToString();
                Form1.flight.PlaceOfDeparture = DgvFlight.Rows[DgvFlight.CurrentCell.RowIndex].Cells[5].Value.ToString();
                Form1.flight.LandingPlace = DgvFlight.Rows[DgvFlight.CurrentCell.RowIndex].Cells[6].Value.ToString();
                Form1.flight.DepartureDate = DgvFlight.Rows[DgvFlight.CurrentCell.RowIndex].Cells[7].Value.ToString();
                Form1.flight.LandingDate = DgvFlight.Rows[DgvFlight.CurrentCell.RowIndex].Cells[8].Value.ToString();

                EditFlight editFlight = new EditFlight();
                editFlight.ShowDialog();

                RefreshDgvFlight();
                flight = new Flight();
            }
        }
        private void DgvFlightAdd(object sender, EventArgs e)
        {
            EditFlight editFlight = new EditFlight();
            editFlight.ShowDialog();

            RefreshDgvFlight();
            flight = new Flight();
        }
        private void DgvFlightDelete(object sender, EventArgs e)
        {
            if (DgvFlight.CurrentCell.RowIndex != -1)
            {
                Form1.flight.ID = Convert.ToInt32(DgvFlight.Rows[DgvFlight.CurrentCell.RowIndex].Cells[0].Value.ToString());

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                string sql = "DELETE FROM [BAZA].[dbo].[flight] WHERE [flight ID] = " + Convert.ToString(Form1.flight.ID);

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                RefreshDgvFlight();
                flight = new Flight();
            }
        }
        private void DgvFlightFilterOn(object sender, EventArgs e)
        {
            filter[3] = " WHERE [place of departure] = N'" + DgvFlight.Rows[DgvFlight.CurrentCell.RowIndex].Cells[5].Value.ToString() + "'";
            RefreshDgvFlight();
        }
        private void DgvFlightFilterOff(object sender, EventArgs e)
        {
            filter[3] = null;
            RefreshDgvFlight();
        }


        public static Ticket ticket = new Ticket();
        private void DgvTicket_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (DgvTicket.HitTest(e.X, e.Y).RowIndex > -1)
                {
                    DgvTicket.CurrentCell = DgvTicket[DgvTicket.HitTest(e.X, e.Y).ColumnIndex, DgvTicket.HitTest(e.X, e.Y).RowIndex];

                }

                ContextMenu Menu = new ContextMenu();
                Menu.MenuItems.Add("Редактировать", new EventHandler(DgvTicketEdit));
                Menu.MenuItems.Add("Добавть", new EventHandler(DgvTicketAdd));
                Menu.MenuItems.Add("Удалить", new EventHandler(DgvTicketDelete));
                if (selectedFlightID.Count > 0)
                {
                    Menu.MenuItems.Add("Показать всё", new EventHandler(DgvTicketViewAll));
                }

                Menu.Show(DgvTicket, new Point(e.X, e.Y));
            }
        } // Билетики
        private void DgvTicketEdit(object sender, EventArgs e)
        {
            if (DgvTicket.CurrentCell.RowIndex != -1)
            {
                Form1.ticket.ID = Convert.ToInt32(DgvTicket.Rows[DgvTicket.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Form1.ticket.FlightID = DgvTicket.Rows[DgvTicket.CurrentCell.RowIndex].Cells[1].Value.ToString();
                Form1.ticket.PassengerID = DgvTicket.Rows[DgvTicket.CurrentCell.RowIndex].Cells[2].Value.ToString();
                Form1.ticket.TicketPrice = DgvTicket.Rows[DgvTicket.CurrentCell.RowIndex].Cells[7].Value.ToString();
                Form1.ticket.TicketType = DgvTicket.Rows[DgvTicket.CurrentCell.RowIndex].Cells[8].Value.ToString();
                Form1.ticket.Seat = DgvTicket.Rows[DgvTicket.CurrentCell.RowIndex].Cells[9].Value.ToString();

                EditTicket editTicket = new EditTicket();
                editTicket.ShowDialog();

                Form1.ticket = new Ticket();
                RefreshDgvTicket();
                RefreshDgvPassenger();
            }
        }
        private void DgvTicketAdd(object sender, EventArgs e)
        {
            EditTicket editTicket = new EditTicket();
            editTicket.ShowDialog();

            RefreshDgvTicket();
            RefreshDgvPassenger();
            Form1.ticket = new Ticket();
        }
        private void DgvTicketDelete(object sender, EventArgs e)
        {
            if (DgvTicket.CurrentCell.RowIndex != -1)
            {
                Form1.ticket.ID = Convert.ToInt32(DgvTicket.Rows[DgvTicket.CurrentCell.RowIndex].Cells[0].Value.ToString());

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                string sql = "DELETE FROM [BAZA].[dbo].[ticket] WHERE [ticket ID] = " + Convert.ToString(Form1.ticket.ID);

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                RefreshDgvTicket();
                RefreshDgvPassenger();
                Form1.ticket = new Ticket();
            }
        }
        private void DgvTicketViewAll(object sender, EventArgs e)
        {
            selectedFlightID = new List<string>();
            RefreshDgvTicket();
        }
    }
}