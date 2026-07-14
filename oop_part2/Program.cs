namespace oop_part2;


class Room
{
    public int roomNumber;
    public string roomType;
    public double pricePerNight;
    public bool isAvailable;


    public Room(string roomType,int roomNumber,double pricePerNight, bool isAvailable)
    {
        this.roomNumber = roomNumber;
        this.pricePerNight = pricePerNight;
        this.roomType = roomType;
        this.isAvailable = isAvailable;
    }


    public void displayRoom()
    {
        Console.WriteLine("here is the room details:");
        Console.WriteLine($" the room number:{roomNumber}");
        Console.WriteLine($"the room type:{roomType}");
        Console.WriteLine($"price per night for this room:{pricePerNight}$");
        Console.WriteLine($"is the room available:{isAvailable}");
    }
    
}


class Guest
{
    public int guestId;
    public string guestName;
    public int roomNumber;
    public DateTime checkInDate;
    public int totalNights;

    

    public void displayGuest()
    {
        Console.WriteLine("here is the guest detail:");
        Console.WriteLine($"the guest id : {guestId}");
        Console.WriteLine($" the gust name:{guestName}");
        Console.WriteLine($"the guest room number{roomNumber}");
        Console.WriteLine($"checkin date: {checkInDate}");
        Console.WriteLine($"total nights of {guestName} at the hotel:{totalNights}");
    }

    public void calculateTotalCost()
    {
        ///////
    }
    

}

class Program
{


    static List<Room> rooms = new List<Room>();
    static List<Guest> guests = new List<Guest>();



    static void Main(string[] args)
    {
        rooms.Add(new Room("singel", 1, 22, true));
        rooms.Add(new Room("singel", 2, 22, true));
        rooms.Add(new Room("Double", 3, 32, true));
        rooms.Add(new Room("Double", 14, 32, true));
        rooms.Add(new Room("Suite", 13, 60, true));
        rooms.Add(new Room("Suite", 19, 60, true));


        bool keepRunning = true;

        while (keepRunning)
        {
            // 1. Clear the screen for a clean look each time the menu loads
            Console.Clear();

            // 2. Display the Main Menu Layout
            Console.WriteLine("================================================");
            Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
            Console.WriteLine("================================================");
            Console.WriteLine(" 1. Add New Room");
            Console.WriteLine(" 2. Register New Guest");
            Console.WriteLine(" 3. Book a Room for a Guest");
            Console.WriteLine(" 4. View All Rooms");
            Console.WriteLine(" 5. View All Guests");
            Console.WriteLine(" 6. Search & Filter Rooms");
            Console.WriteLine(" 7. Guest & Booking Statistics");
            Console.WriteLine(" 8. Update Room Price");
            Console.WriteLine(" 9. Guest Lookup by Name");
            Console.WriteLine("10. Room Type Breakdown Report");
            Console.WriteLine("11. Check Out a Guest");
            Console.WriteLine("12. Remove Unavailable Rooms");
            Console.WriteLine("13. Extend Guest Stay");
            Console.WriteLine("14. Highest Revenue Booking");
            Console.WriteLine("15. Guest Pagination Viewer");
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("================================================");
            Console.Write("Enter your choice: ");


            switch (Console.ReadLine())
            {
                case "1":
                    bool run = true;
                    while (run)
                    {
                        Console.Write("dear clerk, enter the room number:");
                        int roomNumber = int.Parse(Console.ReadLine());
                        Console.Write("room type:");
                        string roomtype = Console.ReadLine();
                        Console.Write("room price per night :");
                        double roomPrice = double.Parse(Console.ReadLine());
                        if (roomNumber < 0 || roomPrice < 0)
                        {
                            Console.WriteLine("invalid , you typed negative  input");
                        }
                        else
                        {
                            run = false;
                            bool roomExist = rooms.Any(room => room.roomNumber == roomNumber);
                            if (!roomExist)
                            {
                                rooms.Add(new Room(roomtype, roomNumber, roomPrice, true));
                            }
                            else
                            {
                                Console.WriteLine(" error, this room number already exist.");
                            }
                        }

                        
                    }break;
            }
        



    }
    }
}