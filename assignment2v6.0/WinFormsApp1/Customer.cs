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

namespace assignment2
{
    public partial class Customer : Form
    {
        LoginForm loginform;
        public Customer(LoginForm loginform, string username)
        {
            InitializeComponent();
            this.loginform = loginform;
            welcomeLabel.Text = "Welcome " + username + "!";

            // displayed assigned room number
            int assignedRoom = GetAssignedRoomNumber(username);

            if (assignedRoom != -1)
            {
                roomNo.Text += " " + assignedRoom;
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
        private int GetAssignedRoomNumber(string username)
        {
            try
            {
                string[] lines = File.ReadAllLines("roomBookings.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 3)
                    {
                        string bookedUsername = parts[1].Trim();
                        int roomNumber = 0;

                        if (bookedUsername == username && int.TryParse(parts[2], out roomNumber))
                        {
                            return roomNumber;
                        }

                        /*else
                        {
                            roomNo.Text += " No room assigned yet.";
                            break;
                        }*/
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Debug.WriteLine("The file is not found; you can create a new booking");
            }

            return -1;
        }

    }
}
