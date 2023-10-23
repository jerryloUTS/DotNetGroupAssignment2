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
    public partial class BookRoomForm : Form
    {
        private string customerUserName;
        private int roomId;
        public BookRoomForm(string customerUserName, int roomId)
        {
            InitializeComponent();
            this.customerUserName = customerUserName;
            this.roomId = roomId;

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {   
            //validation to check if the room is vacant will come later.
            //generates random id
            Random random = new Random();
            int randomId = random.Next();
                
            DateTime checkInDate = dtpCheckInDate.Value;
            DateTime checkOutDate = dtpCheckOutDate.Value;
            int numbersOfGuests = Convert.ToInt32(numDpGuests.Value);
            int numbersOfDependents = Convert.ToInt32(numDpDependents.Value);
            RoomBooking newBooking = new RoomBooking(randomId, customerUserName, roomId, checkInDate, checkOutDate, numbersOfGuests, numbersOfDependents);
            //stores it into a text file
            AddToTxtFile(newBooking);
            MessageBox.Show("Room has been booked sucecsessfuly.");
        }

        // stores booking details into a text file.
        public void AddToTxtFile(RoomBooking roomBooking)
        {
            //appends it to a text file
            File.AppendAllText("roomBookings.txt", roomBooking.GetTxtFileString());
        }
    }
}
