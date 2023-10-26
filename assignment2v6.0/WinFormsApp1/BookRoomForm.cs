using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            //this will be used to check if this room is vacent
            List<RoomBooking> roomBookings = new List<RoomBooking>();
            
            if (IsAnyRoomsBooked(roomBookings, newBooking))
            {
                MessageBox.Show("Sorry, this room is already booked by someone else.");
            }
            else
            {
                //stores it into a text file
                AddToTxtFile(newBooking);
                MessageBox.Show("Room has been booked sucecsessfuly.");
            }
            
        }

        // stores booking details into a text file.
        public void AddToTxtFile(RoomBooking roomBooking)
        {
            //appends it to a text file
            File.AppendAllText("roomBookings.txt", roomBooking.GetTxtFileString());
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
                
            }
            //this will not cause the program to crash if there is no file found, it will just display a message on the debug line.
            catch(FileNotFoundException)
            {
                Debug.WriteLine("The file is not found, you can create a new booking");
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
                //only checks the actual edge cases.
                if (currentBooking.CheckInDate == newBooking.CheckInDate || currentBooking.CheckOutDate == newBooking.CheckOutDate)
                {
                    return true;
                }
                else if (currentBooking.CheckInDate >= newBooking.CheckInDate && currentBooking.CheckOutDate <= newBooking.CheckOutDate)
                {
                    return true;
                }
            }     
            return false; 
            
        }

        //helper function that will loop through a list to check if it is booked
        private bool IsAnyRoomsBooked(List<RoomBooking> roomBookings, RoomBooking newBooking) 
        {
            foreach(RoomBooking booking in roomBookings) 
            {
                //returns true if it catchs the room within the booking date ranges.
                if(IsBooked(booking, newBooking))
                {
                    return true;
                }
            }
            //will return false if it is not booked or there are no items in the list.
            return false;
        }


    }
}
