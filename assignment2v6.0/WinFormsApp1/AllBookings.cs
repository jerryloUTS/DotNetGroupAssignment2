using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            DataColumn bookingIdCol = new DataColumn();
            bookingIdCol.ColumnName = "id";
            DataColumn roomCodeCol = new DataColumn();
            roomCodeCol.ColumnName = "roomCode";
            DataColumn customerUserNameCol = new DataColumn();
            customerUserNameCol.ColumnName = "customerUserName";
            DataColumn checkInDateCol = new DataColumn();
            checkInDateCol.ColumnName = "checkInDate";
            DataColumn checkInTimeCol = new DataColumn();
            checkInTimeCol.ColumnName = "checkInTime";
            DataColumn checkOutDateCol = new DataColumn();
            checkOutDateCol.ColumnName = "checkOutDate";
            DataColumn checkOutTimeCol = new DataColumn();
            checkOutTimeCol.ColumnName = "checkOutTime";
            DataColumn guestsCol = new DataColumn();
            guestsCol.ColumnName = "guests";
            DataColumn dependentsCol = new DataColumn();
            dependentsCol.ColumnName = "dependents";
            //adds it onto the data table
            bookedRooms.Columns.Add(bookingIdCol);
            bookedRooms.Columns.Add(roomCodeCol);
            bookedRooms.Columns.Add(customerUserNameCol);
            bookedRooms.Columns.Add(checkInDateCol);
            bookedRooms.Columns.Add(checkInTimeCol);
            bookedRooms.Columns.Add(checkOutDateCol);
            bookedRooms.Columns.Add(checkOutTimeCol);
            bookedRooms.Columns.Add(guestsCol);
            bookedRooms.Columns.Add(dependentsCol);
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
            try
            {
                foreach (string line in File.ReadAllLines("roomBookings.txt"))
                {
                    var row = bookedRooms.NewRow();
                    string[] splits = line.Split(",");
                    row["id"] = splits[0];
                    row["roomCode"] = splits[2];
                    row["customerUserName"] = splits[1];
                    row["checkInDate"] = ConvertToShortDateOnly(splits[3]);
                    row["checkInTime"] = ConvertToTimeOnly(splits[3]);
                    row["checkOutDate"] = ConvertToShortDateOnly(splits[4]);
                    row["checkOutTime"] = ConvertToTimeOnly(splits[4]);
                    row["guests"] = splits[5];
                    row["dependents"] = splits[6];
                    bookedRooms.Rows.Add(row);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("An error has occurred when loading saved bookings from disk.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //this is a function that will be used for converting dates from a string into a dateTime object and convert it back to string, it will be used to display the appropriate date formats and a time in a seperate column
        private static String ConvertToShortDateOnly(string dateTimeStr)
        {
            try
            {
                DateTime date = Convert.ToDateTime(dateTimeStr);
                string shortDateFormat = date.ToString("dd/MM/yyyy");
                return shortDateFormat;
            }
            catch (FormatException)
            {
                DateTime date = DateTime.ParseExact(dateTimeStr, "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                string shortDateFormat = date.ToString("dd/MM/yyyy");
                return shortDateFormat;
            }
        }

        private static string ConvertToTimeOnly(string dateTimeStr)
        {
            try
            {
                DateTime date = Convert.ToDateTime(dateTimeStr);
                string timeDateFormat = date.ToString("hh:mm tt");
                return timeDateFormat;
            }
            //will try another method to parse into date object if it fails
            catch (FormatException)
            {
                DateTime date = DateTime.ParseExact(dateTimeStr, "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                string timeDateFormat = date.ToString("hh:mm tt");
                return timeDateFormat;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
