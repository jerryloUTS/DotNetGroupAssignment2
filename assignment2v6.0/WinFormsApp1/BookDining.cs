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
    public partial class BookDining : Form
    {
        private int roomNumber;

        public BookDining(int detectedRoomNumber)
        {
            InitializeComponent();
            roomNumber = detectedRoomNumber;
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            // Retrieve the selected date, time, and number of people.
            DateTime selectedDate = reserveDate.Value;
            DateTime selectedTime = reserveTime.Value;
            int numberOfPeople = (int)numGuests.Value;

            // Create a reservation
            string reservation = $"{roomNumber},{selectedDate},{selectedTime},{numberOfPeople}";

            // Save the reservation to a text file, separating reservations by room number.
            string reservationsFile = "DinnerReservations.txt";
            File.AppendAllText(reservationsFile, reservation + Environment.NewLine);

            // Provide feedback to the user (optional).
            MessageBox.Show("Reservation made successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form or perform any other actions as needed.
            this.Close();
        }
    }
}
