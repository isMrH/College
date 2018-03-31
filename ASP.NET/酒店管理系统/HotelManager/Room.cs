using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Model
{
    public class Room
    {
        int roomId;

        public int RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }
        int roomNumber;

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        int bedNumber;

        public int BedNumber
        {
            get { return bedNumber; }
            set { bedNumber = value; }
        }
        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }

      
        int guestNumber;

        public int GuestNumber
        {
            get { return guestNumber; }
            set { guestNumber = value; }
        }
        int typeId;

        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }
    }
}
