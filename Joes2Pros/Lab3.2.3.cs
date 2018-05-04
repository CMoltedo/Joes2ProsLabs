using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class House
    {
        enum Color
        {
            Red,
            Blue,
            Green,
            Pink,
            Yellow

        }

        struct Room
        {
            public string Name;
            public Color RoomColor;
            public byte Windows;
            public byte Doors;
        }
        public static void ShowRoomDetails()
        {
            Room room1 = new Room();
            Room room2 = new Room();
            Room room3 = new Room();

            room1.Name = "Alpha";
            room1.RoomColor = Color.Red;
            room1.Windows = 5;
            room1.Doors = 2;

            room2.Name = "Beta";
            room2.RoomColor = Color.Green;
            room2.Windows = 3;
            room2.Doors = 2;

            room3.Name = "Gamma";
            room3.RoomColor = Color.Yellow;
            room3.Windows = 0;
            room3.Doors = 1;

            Room[] Rooms = new Room[3];

            Rooms[0] = room1;
            Rooms[1] = room2;
            Rooms[2] = room3;

            foreach(Room room in Rooms)
            {
                Console.WriteLine($"{room.Name} is {room.RoomColor} with {room.Windows.ToString()} windows and {room.Doors.ToString()} doors.");
            }


        }
    }
}
