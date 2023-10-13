using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    enum RoomClass
    {
        Economy,
        Standard,
        Platnum,
        Premium
    }
    internal class HotelRoom
    {
        private int roomCode;
        private string roomName;
        private RoomClass roomClass;
        private bool isAvailable;
        private double pricePerNight;
        private double discountedPrice;
        private int levelNumber; //this is used to determine what level of the hotel building the room is on.
        private double roomLength;
        private double roomHeight;
        private int maximumGuests;
        private bool petsAllowed;

        public double RoomSize 
        {
            get => roomLength * roomHeight; 
        }

        public double PricePerHour
        {
            get => pricePerNight / 24;
        }

        public bool IsDiscount
        {
            get => discountedPrice < pricePerNight;
        }

    }
}
