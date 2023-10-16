using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Address
    {
        private string addressLine1;
        private string? addressLine2; //this is nullable because not every home has a second address line.
        private string city;
        private string? state;
        private string country;
        private string postCode;

        

        public Address(string addressLine1, string? addressLine2, string city, string? state, string country, string postCode)
        {
            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.city = city;
            this.state = state;
            this.country = country;
            this.postCode = postCode;
        }

        public string AddressLine1 { get => addressLine1; set => addressLine1 = value; }
        public string? AddressLine2 { get => addressLine2; set => addressLine2 = value; }
        public string City { get => city; set => city = value; }
        public string? State { get => state; set => state = value; }
        public string Country { get => country; set => country = value; }
        public string PostCode { get => postCode; set => postCode = value; }
    }
}
