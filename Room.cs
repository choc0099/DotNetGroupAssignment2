using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment2
{
    class Room
    {
        string roomID, roomSize, bedSize, roomSight, roomFeatures, roomPrice, roomInfo;

        public Room(string roomID, string roomSize, string bedSize, string roomSight, string roomFeatures, string roomPrice, string roomInfo)
        {
            this.roomID = roomID;
            this.roomSize = roomSize;
            this.bedSize = bedSize;
            this.roomSight = roomSight;
            this.roomFeatures = roomFeatures;
            this.roomPrice = roomPrice;
            this.roomInfo = roomInfo;
            StreamWriter file = new StreamWriter("rooms.txt", true);
            file.WriteLine(roomID + "," + roomSize + "," + bedSize + "," + roomSight + "," + roomFeatures + ",$" + roomPrice + "," + roomInfo);
            file.Close();
        }

        public string getRoomID()
        {
            return this.roomID;
        }
        public void setRoomID (string roomID)
        {
            this.roomID = roomID;
        }

        public string getroomSize()
        {
            return this.roomSize;
        }
        public void setRoomSize(string roomSize)
        {
            this.roomSize = roomSize;
        }
        public string getBedSize()
        {
            return this.bedSize;
        }
        public void setBedSize(string bedSize)
        {
            this.bedSize = bedSize;
        }
        public string getRoomSight()
        {
            return this.roomSight;
        }
        public void setRoomSight(string roomSight)
        {
            this.roomSight = roomSight;
        }

        public string getRoomFeataures()
        {
            return this.roomFeatures;
        }
        public void setRoomFeatures(string roomFeatures)
        {
            this.roomFeatures = roomFeatures;
        }

        public string getRoomPrice()
        {
            return this.roomPrice;
        }
        public void setRoomPrice(string roomPrice)
        {
            this.roomPrice = roomPrice;
        }

        public string getRoomInfo()
        {
            return this.roomInfo;
        }
        public void setRoomInfo(string roomInfo)
        {
            this.roomInfo = roomInfo;
        }


        //---------------------------------------

        public List<Room> getRooms()
        {
            String[] roomInfo = System.IO.File.ReadAllLines("roomDisplay.txt");
            List<Room> rooms = new List<Room>();

            try
            {
                foreach (string i in roomInfo)
                {
                    string[] temp = i.Split(',');
                    for (int g = 0; g < temp.Length; g = g + 6)
                    {
                        Room room = new Room(temp[g], temp[g + 1], temp[g + 2], temp[g + 3], temp[g + 4], temp[g + 5], temp[g + 6]);
                        rooms.Add(room);
                        //user.printUser();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
            return rooms;
        }



    }
}
