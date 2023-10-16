using System;
using System.Collections.Generic;
using System.Drawing.Text;
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
    public class HotelRoom
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
        private RoomFacilities roomFacilities;

        public double RoomSize 
        {
            get => RoomLength * RoomHeight; 
        }

        public double PricePerHour
        {
            get => PricePerNight / 24;
        }

        public bool IsDiscount
        {
            get => DiscountedPrice < PricePerNight;
        }

        public int RoomCode { get => roomCode; set => roomCode = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }
        public double PricePerNight { get => pricePerNight; set => pricePerNight = value; }
        public double DiscountedPrice { get => discountedPrice; set => discountedPrice = value; }
        public int LevelNumber { get => levelNumber; set => levelNumber = value; }
        public double RoomLength { get => roomLength; set => roomLength = value; }
        public double RoomHeight { get => roomHeight; set => roomHeight = value; }
        public int MaximumGuests { get => maximumGuests; set => maximumGuests = value; }
        public bool PetsAllowed { get => petsAllowed; set => petsAllowed = value; }
        internal RoomClass RoomClass { get => roomClass; set => roomClass = value; }
        internal RoomFacilities RoomFacilities { get => roomFacilities; set => roomFacilities = value; }

        
        public HotelRoom(int roomCode, string roomName, RoomClass roomClass, bool isAvailable, double pricePerNight, double discountedPrice, int levelNumber, double roomLength, double roomHeight, int maximumGuests, bool petsAllowed, RoomFacilities roomFacilities)
        {
            this.roomLength = roomLength;
            this.roomHeight = roomHeight;
            this.maximumGuests = maximumGuests;
            this.petsAllowed = petsAllowed;
            this.roomFacilities = roomFacilities;
            this.roomCode = roomCode;
            this.roomName = roomName;
            this.isAvailable = isAvailable;
            this.pricePerNight = pricePerNight;
            this.discountedPrice = discountedPrice;
            this.levelNumber = levelNumber;
            this.roomLength = roomLength;
            this.roomHeight = roomHeight;
            this.maximumGuests = maximumGuests;
            this.petsAllowed = petsAllowed;
            this.roomClass = roomClass;
            this.roomFacilities = roomFacilities;
        }
    }
}
