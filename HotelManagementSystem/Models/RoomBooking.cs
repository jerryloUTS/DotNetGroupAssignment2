using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class RoomBooking
    {
        private int id;
        private int customerId;
        private int roomId;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        

        public int Id 
        { 
            get => id; 
            set => id = value;
        }
        public int CustomerId 
        {
            get => customerId;
            set => customerId = value; 
        }
        public int RoomId { 
            get => roomId;
            set => roomId = value;
        }
        public DateTime CheckInDate 
        { 
            get => checkInDate; 
            set => checkInDate = value; 
        }
        public DateTime CheckOutDate 
        { 
            get => checkOutDate; 
            set => checkOutDate = value; 
        }
        

        public RoomBooking(int id, int customerId, int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            this.id = id;
            this.customerId = customerId;
            this.roomId = roomId;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
        }
    }
}
