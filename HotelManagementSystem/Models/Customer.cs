using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Customer
    {
        private int id;
        private string name;
        private string email;
        private string phoneNumber;
        private Address address;
        private CreditCard? creditCardDetails;
        private List<RoomBooking> roomBookings = new List<RoomBooking>();

        public Customer(int id, string name, string email, string phoneNumber, Address address, CreditCard? creditCardDetails)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.creditCardDetails = creditCardDetails;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public Address Address { get => address; set => address = value; }
        public CreditCard? CreditCardDetails { get => creditCardDetails; set => creditCardDetails = value; }
        public List<RoomBooking> RoomBookings { get => roomBookings; set => roomBookings = value; }
    }
}
