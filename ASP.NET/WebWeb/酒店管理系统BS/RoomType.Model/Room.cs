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
        int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        RoomType typeName;

        public RoomType TypeName
        {
            get { return typeName; }
            set { typeName = value; }
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
    }
}
