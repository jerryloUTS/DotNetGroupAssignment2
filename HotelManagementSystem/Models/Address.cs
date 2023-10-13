using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    internal class Address
    {
        private string addressLine1;
        private string? addressLine2; //this is nullable because not every home has a second address line.
        private string city;
        private string state;
        private string country;
        private string postCode;
    }
}
