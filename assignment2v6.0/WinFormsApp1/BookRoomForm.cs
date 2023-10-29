using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class BookRoomForm : Form
    {
        private string customerUserName;
        private int roomCode;
        private bool formComplete = false;
        public bool FormComplete { get => formComplete; set => formComplete = value; }

        public BookRoomForm(string customerUserName, int roomCode)
        {
            InitializeComponent();
            this.customerUserName = customerUserName;
            this.roomCode = roomCode;

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

            DateTime checkInDate = CombineDateAndTimeFields(dtpCheckInDate.Value, dtpCheckInTime.Value);
            DateTime checkOutDate = CombineDateAndTimeFields(dtpCheckOutDate.Value, dtpCheckOutTime.Value);
            int numbersOfGuests = Convert.ToInt32(numDpGuests.Value);
            int numbersOfDependents = Convert.ToInt32(numDpDependents.Value);
            RoomBooking newBooking = new RoomBooking(randomId, customerUserName, roomCode, checkInDate, checkOutDate, numbersOfGuests, numbersOfDependents);
            //this will be used to check if this room is vacent
            List<RoomBooking> roomBookings = GetBookedRooms();
            //checks if there is numbers of guests
            if (!(numbersOfGuests > 0))
            {
                MessageBox.Show("Please Input the numbers of guests", "Not all fields entered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //checks if either of the dates are within range, for example if the check in date is greater then the checkout date, it should display an error.
            else if (checkInDate > checkOutDate)
            {
                MessageBox.Show("The check out date must be equal or greater then the check in date.", "Invalid Date Selection.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IsAnyRoomsBooked(roomBookings, newBooking))
            {
                MessageBox.Show("Sorry, this room is already booked by someone else.", "Room Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //stores it into a text file
                AddToTxtFile(newBooking);
                //sends the email to the customer
                EmailBookingConfirmation(newBooking);
                MessageBox.Show("Room has been booked sucecsessfuly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                formComplete = true;
                this.Close();
            }

        }

        // stores booking details into a text file.
        public void AddToTxtFile(RoomBooking roomBooking)
        {
            //appends it to a text file
            File.AppendAllText("roomBookings.txt", roomBooking.GetTxtFileString() + "\n");
        }

        //retrieves a list of room bookings from a text file
        private List<RoomBooking> GetBookedRooms()
        {
            List<RoomBooking> roomBookings = new List<RoomBooking>();
            try
            {
                foreach (string line in File.ReadAllLines("roomBookings.txt"))
                {
                    string[] splits = line.Split(',');
                    //creates a new room booking object
                    RoomBooking booking = new RoomBooking(
                        Convert.ToInt32(splits[0]), //booking id
                        splits[1], //customer's username
                        Convert.ToInt32(splits[2]), //room id
                        Convert.ToDateTime(splits[3]), //check in date
                        Convert.ToDateTime(splits[4]), //check out date
                        Convert.ToInt32(splits[5]), //numbers of guests
                        Convert.ToInt32(splits[6]) //numbers of dependents.
                        );
                    //adds it to the list
                    roomBookings.Add(booking);
                }
                Debug.WriteLine("Bookings text file loaded");

            }
            //this will try another way of parsing dates if a format exception has occurred.
            /*catch(FormatException)
            {
                List<RoomBooking> alternateRoomBookings = new List<RoomBooking>();
                
                
                foreach (string line in File.ReadAllLines("roomBookings.txt"))
                {
                    string[] splits = line.Split(',');
                    //creates a new room booking object
                    RoomBooking booking = new RoomBooking(
                        Convert.ToInt32(splits[0]), //booking id
                        splits[1], //customer's username
                        Convert.ToInt32(splits[2]), //room id
                        DateTime.ParseExact(splits[3], "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture), //check in date
                        DateTime.ParseExact(splits[4], "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture), //check out date
                        Convert.ToInt32(splits[5]), //numbers of guests
                        Convert.ToInt32(splits[6]) //numbers of dependents.
                        );
                    //adds it to the list
                    alternateRoomBookings.Add(booking);
                }
                Debug.WriteLine("Trying another method to parse dates.");
                return alternateRoomBookings;

                
            }*/
            //this will not cause the program to crash if there is no file found, it will just display a message on the debug line.
            catch (FileNotFoundException)
            {
                Debug.WriteLine("The file is not found, you can create a new booking");
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return roomBookings;

        }

        //this is a helper function to check if it is already booked
        private bool IsBooked(RoomBooking currentBooking, RoomBooking newBooking)
        {
            //checks the room id first.
            if (currentBooking.RoomId == newBooking.RoomId)
            {
                //then a nested if statements occurrs to check the booking dates for that specific room.
                //checks the date ranges if hotel room is already booked for some or all of the selected dates.
                if (currentBooking.CheckInDate < newBooking.CheckOutDate && newBooking.CheckInDate < currentBooking.CheckOutDate)
                {
                    return true;
                }
            }
            return false;

        }

        //helper function that will loop through a list to check if it is booked
        private bool IsAnyRoomsBooked(List<RoomBooking> roomBookings, RoomBooking newBooking)
        {
            foreach (RoomBooking booking in roomBookings)
            {
                //returns true if it catchs the room within the booking date ranges.
                if (IsBooked(booking, newBooking))
                {
                    return true;
                }
            }
            //will return false if it is not booked or there are no items in the list.
            return false;
        }

        private void lblBookingInfo_Click(object sender, EventArgs e)
        {

        }

        private void BookRoomForm_Load(object sender, EventArgs e)
        {
            //displays a message with the customer username and room code.
            lblBookingInfo.Text = "You are Booking a room for " + customerUserName + " in Room #" + roomCode;
            //sets the min date range for the date time pickers so they can only book for days ahead.
            dtpCheckInDate.MinDate = DateTime.Now;
            dtpCheckOutDate.MinDate = DateTime.Now;
        }

        //this is a helperfunction that will combine both the date and times from seperate form controls.
        private DateTime CombineDateAndTimeFields(DateTime dateFieldValue, DateTime timeFieldValue)
        {
            return dateFieldValue.Date + timeFieldValue.TimeOfDay;
        }

        private void EmailBookingConfirmation(RoomBooking roomBooking)
        {
            try
            {
                //displays the busy cursor symbol on the mouse pointer to the user while the smtp client connects to the server
                Cursor.Current = Cursors.WaitCursor;
                string customerName = "";
                string customerEmail = "";
                foreach(string line in File.ReadAllLines(this.customerUserName + ".txt"))
                {
                    string[] splits = line.Split('|');
                    customerName = splits[0];
                    customerEmail = splits[1];
                }
                //sends the request
                MailManager.SendBookingConfirmation(customerName, customerEmail, roomBooking);
            }
            catch(FileNotFoundException)
            {
                Debug.WriteLine("Unable to send confirmation email because the text file was not found.");
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Unable to send email " + ex.Message);
            }
            finally
            {
                //returns back to a normal cursor.
                Cursor.Current = Cursors.Default;
            }
        }
    }


}
