using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace assignment2
{
    public partial class Customer : Form
    {
        LoginForm loginform;
        private string username;

        public Customer(LoginForm loginform, string username)
        {
            InitializeComponent();
            this.loginform = loginform;
            this.username = username;
            welcomeLabel.Text = "Welcome " + username + "!";

            // displayed assigned room number
            var roomInfo = GetAssignedRoomInfo(username);

            if (roomInfo.Item1 != -1)
            {
                roomNo.Text += " " + roomInfo.Item1;
                checkInDate.Text = roomInfo.Item2.ToShortDateString();
                checkOutDate.Text = roomInfo.Item3.ToShortDateString();
            }
            else
            {
                roomNo.Text += " No room assigned yet.";
                checkInDate.Text = "N/A";
                checkOutDate.Text = "N/A";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            IncidentReport incidentReportForm = new IncidentReport();
            incidentReportForm.Show();
        }

        // fetching the assigned room number from the roomBookings file
        private Tuple<int, DateTime, DateTime> GetAssignedRoomInfo(string username)
        {
            try
            {
                string[] lines = File.ReadAllLines("roomBookings.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 7)
                    {
                        string bookedUsername = parts[1].Trim();
                        int roomNumber = 0;
                        DateTime checkInDate;
                        DateTime checkOutDate;

                        if (bookedUsername == username && int.TryParse(parts[2], out roomNumber) &&
                            DateTime.TryParse(parts[3], out checkInDate) && DateTime.TryParse(parts[4], out checkOutDate))
                        {
                            return Tuple.Create(roomNumber, checkInDate, checkOutDate);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Debug.WriteLine("The file is not found; you can create a new booking");
            }

            return Tuple.Create(-1, DateTime.MinValue, DateTime.MinValue); // Indicates no booking found
        }

        private void bookDiningButton_Click(object sender, EventArgs e)
        {
            // Detect the room number
            int detectedRoomNumber = GetAssignedRoomInfo(username).Item1;

            // Create an instance of BookDining with the room number
            BookDining bookDiningForm = new BookDining(detectedRoomNumber);
            //BookDining bookDining = new BookDining();
            bookDiningForm.Show();
        }

        private void roomServiceButton_Click(object sender, EventArgs e)
        {
            AllDishes viewFood = new AllDishes();
            viewFood.Show();
        }
    }
}
