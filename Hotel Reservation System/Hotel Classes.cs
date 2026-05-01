using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_Reservation_System
{
    enum RoomType
    {
        Single,
        Double,
        Suite
    }

    class Customer
    {
        private static int counter = 0;

        public int Id { get; private set; }
        public string Name { get; set; }
        public long Phone { get; set; }
        

        public Customer()
        {
            Id = ++counter;
        }
    }

    class Room
    {
        public int RoomNum;
        public float PricePerNight;
        public bool IsAvailable = true;
        public RoomType Type;

        public Room(int num, float price, RoomType type)
        {
            RoomNum = num;
            PricePerNight = price;
            Type = type;
        }

        public virtual string GetInfo()
        {
            return $"Room {RoomNum} - {Type} - Price: {PricePerNight}$";
        }
    }

    class SingleRoom : Room
    {
        public SingleRoom(int num, float price)
            : base(num, price, RoomType.Single) { }

        public override string GetInfo()
        {
            return $"Single Room {RoomNum}";
        }
    }

    class DoubleRoom : Room
    {
        public DoubleRoom(int num, float price)
            : base(num, price, RoomType.Double) { }

        public override string GetInfo()
        {
            return $"Double Room {RoomNum}";
        }
    }

    class SuiteRoom : Room
    {
        public SuiteRoom(int num, float price)
            : base(num, price, RoomType.Suite) { }

        public override string GetInfo()
        {
            return $"Suite {RoomNum}";
        }
    }
    class Booking
    {
        public Customer Customer;
        public Room Room;

        public Booking(Customer c, Room r)
        {
            Customer = c;
            Room = r;
        }
    }



    class HotelSystem
    {
        public Room[] rooms = new Room[45];
        public Customer[] customers = new Customer[45];
        public Booking[] bookings = new Booking[45];

        public int bookingCount = 0;
        public int roomCount = 0;
        public int custCount = 0;

        public bool RoomExists(int roomNum)
        {
            for (int i = 0; i < roomCount; i++)
            {
                if (rooms[i] != null && rooms[i].RoomNum == roomNum)
                    return true;
            }
            return false;
        }

        public void AddRoom(Room r)
        {
            if (RoomExists(r.RoomNum))
            {
                MessageBox.Show("Room already exists!");
                return;
            }
            rooms[roomCount++] = r;
            SaveAllRooms();
        }

        public Room[] GetRooms()
        {
            return rooms;
        }
        public float priceByRoomNum(int num)
        {
            for (int i = 0; i < roomCount; i++)
            {
                if (rooms[i].RoomNum == num)
                {
                    return rooms[i].PricePerNight;
                }

            }
            return 0;
        }
        public void SaveAllRooms()
        {
            using (StreamWriter sw = new StreamWriter("allrooms.txt", false))
            {
                for (int i = 0; i < roomCount; i++)
                {
                    var r = rooms[i];
                    sw.WriteLine($"{r.RoomNum},{r.Type},{r.PricePerNight},{r.IsAvailable}");
                }
            }
        }

        public void LoadRooms()
        {
            if (!File.Exists("allrooms.txt"))
                return;

            StreamReader sr = new StreamReader("allrooms.txt");

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                int num = int.Parse(data[0]);
                string type = data[1].Trim();
                float price = float.Parse(data[2]);
                bool isAvailable = bool.Parse(data[3]);

                Room r;

                if (type == "Single")
                    r = new SingleRoom(num, price);
                else if (type == "Double")
                    r = new DoubleRoom(num, price);
                else
                    r = new SuiteRoom(num, price);

                r.IsAvailable = isAvailable;

                rooms[roomCount++] = r;
            }

            sr.Close();
        }

        public bool BookRoom(int roomNum, Customer c)
        {
            for (int i = 0; i < roomCount; i++)
            {
                if (rooms[i].RoomNum == roomNum && rooms[i].IsAvailable)
                {
                    rooms[i].IsAvailable = false;

                    bookings[bookingCount++] = new Booking(c, rooms[i]);

                    SaveAllRooms();
                    return true;
                }
            }
            return false;
        }
        public void CancelBooking(int roomNum)
        {
            for (int i = 0; i < roomCount; i++)
            {
                if (rooms[i].RoomNum == roomNum)
                {
                    rooms[i].IsAvailable = true;
                    break;
                }
            }

            for (int i = 0; i < bookingCount; i++)
            {
                if (bookings[i] != null && bookings[i].Room.RoomNum == roomNum)
                {
                    bookings[i] = null;
                    break;
                }
            }
        }

    }

}
