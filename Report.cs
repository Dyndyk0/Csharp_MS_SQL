using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD1
{
    public partial class Report : Form
    {
        public void RefreshDgvFlight()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            conn.Open();
            String sql = "Execute create_report";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            conn.Close();

            DgvFlight.DataSource = dt;
            DgvFlight.Columns[0].Visible = false;
            DgvFlight.Columns[1].HeaderText = "Модель самолёта";
            DgvFlight.Columns[2].HeaderText = "Дата вылета";
            DgvFlight.Columns[3].HeaderText = "Длительность полёта (в часах)";
            DgvFlight.Columns[4].HeaderText = "Место взлёта";
            DgvFlight.Columns[5].HeaderText = "место посадки";
            DgvFlight.Columns[6].HeaderText = "Продано мест";
            DgvFlight.Columns[7].HeaderText = "Мест в самолёте";
            DgvFlight.Columns[8].HeaderText = "Доход";

            DgvFlight.ReadOnly = true;
            DgvFlight.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in DgvFlight.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DgvFlight.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public Report()
        {
            InitializeComponent();
            RefreshDgvFlight();
        }
    }
}
