using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class RoomBooking
    {
        private int id;
        private string customerUserName;
        private int roomId;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int numberOfGuests;
        private int numbersOfDependents;
        

        public int Id 
        { 
            get => id; 
            set => id = value;
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
        public string CustomerUserName { get => customerUserName; set => customerUserName = value; }

        public RoomBooking(int id, string customerUserName, int roomId, DateTime checkInDate, DateTime checkOutDate, int numbersOfGuests, int numbersOfDependents)
        {
            this.id = id;
            this.customerUserName = customerUserName;
            this.roomId = roomId;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.numberOfGuests = numbersOfGuests;
            this.numbersOfDependents = numbersOfDependents;
        }

        public string GetTxtFileString()
        {
            string checkInDateStr = checkInDate.ToString();
            string checkOutDateStr = checkOutDate.ToString();
            //returns a txtFile genereated string.
            string s = id + "," + customerUserName + "," + roomId + "," + checkInDateStr + "," + checkOutDateStr;
            s += "," + numberOfGuests + "," + numbersOfDependents;
            return s;
        }
    }
}
