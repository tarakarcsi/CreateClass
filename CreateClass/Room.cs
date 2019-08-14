using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Room
    {
        private int _roomNumber;

        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value;
            }
        }

        public Room(int roomNumber)
        {
            _roomNumber = roomNumber;
        }
    }
}
