using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    //this is a util class for the hotel
    public class HotelMain
    {
        private List<Customer> customers;
        private List<Receptionist> receptionists;
        private List<HotelRoom> rooms;
        private List<Admin> admins;

        public HotelMain() 
        {
            this.customers = new List<Customer>();
            this.admins = new List<Admin>();
            this.rooms = new List<HotelRoom>();
            this.receptionists = new List<Receptionist>();
        }

        public List<Customer> Customers { get => customers; set => customers = value; }
        public List<Receptionist> Receptionists { get => receptionists; set => receptionists = value; }
        public List<Admin> Admins { get => admins; set => admins = value; }
        internal List<HotelRoom> Rooms { get => rooms; set => rooms = value; }
    }
}
