using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class AllBookings : Form
    {
        DataTable bookedRooms = new DataTable();
        public AllBookings()
        {
            InitializeComponent();
        }

        private void AllBookings_Load(object sender, EventArgs e)
        {
            AddBookingColumns();
            LoadBookingsFromTxtFile();
            InitialiseDataGridView();
        }

        private void AddBookingColumns()
        {
            DataColumn roomCodeCol = new DataColumn();
            roomCodeCol.ColumnName = "roomCode";
            DataColumn customerUserNameCol = new DataColumn();
            customerUserNameCol.ColumnName = "customerUserName";
            bookedRooms.Columns.Add(roomCodeCol);
            bookedRooms.Columns.Add(customerUserNameCol);
        }

        private void dgvAllBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //this will initislise the data grid view with a datasource and rename the columns for display.
        private void InitialiseDataGridView()
        {
            dgvAllBookings.DataSource = bookedRooms;
            dgvAllBookings.Columns[0].HeaderText = "Room Code #";

        }

        private void LoadBookingsFromTxtFile()
        {
            foreach(string line in File.ReadAllLines("roomBookings.txt"))
            {
                var row = bookedRooms.NewRow();
                string[] splits = line.Split(",");
                row["roomCode"] = splits[2];
                bookedRooms.Rows.Add(row);
            }
        }
    }
}
