namespace oop_part2;


class Room
{
    public string roomNumber;
    public string roomType;
    public double pricePerNight;
    public bool isAvailable;


    public Room(string roomType,string roomNumber,double pricePerNight, bool isAvailable)
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
    public string guestId;
    public string guestName;
    public string roomNumber;
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
        rooms.Add(new Room("singel", "1", 22, true));
        rooms.Add(new Room("singel", "2", 60, false));
        rooms.Add(new Room("Double", "3", 32, true));
        rooms.Add(new Room("Double", "14", 90, true));
        rooms.Add(new Room("Suite", "13", 23, true));
        rooms.Add(new Room("Suite", "19", 60, true));


        bool keepRunning = true;

        while (keepRunning)
        {
            // 1. Clear the screen for a clean look each time the menu loads

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
                    try
                    {
                        bool run = true;
                        while (run)
                        {
                            Console.Write("dear clerk, enter the room number:");
                            string roomNumber = (Console.ReadLine());
                            Console.Write("room type:");
                            string roomtype = Console.ReadLine();
                            Console.Write("room price per night :");
                            double roomPrice = double.Parse(Console.ReadLine());
              
                          
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
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine("invalid input, tru again ");
                    }

                    break;
                
                
                
                case "2":
                    
                    Console.WriteLine("dear user, please enter you following details: ");
                    Console.Write("1- Guest name: ");
                    string guestName = Console.ReadLine();
                    Console.Write("2- checkin Date (dd/MM/yyyy): ");
                    string checkinDate = Console.ReadLine();
                    Console.Write("1- number of nights planned to stay: ");
                    int numberNights = int.Parse(Console.ReadLine());
                    
                    // auto- generated id, for the quests
                    string guestId = $"{guests.Count + 1:D3}";
                    Console.WriteLine($"Guest Id : {guestId}");
                    Guest G1 = new Guest();
                    G1.guestName = guestName;
                    G1.guestId = guestId;
                    G1.totalNights = numberNights;
                    G1.checkInDate = DateTime.Parse(checkinDate);
                    G1.roomNumber = "not assigned";
                    guests.Add(G1);
                    // --- display guest detail ---
                    Console.WriteLine("\n================================================");
                    Console.WriteLine("           GUEST REGISTRATION DETAILS           ");
                    Console.WriteLine("================================================");
                    Console.WriteLine($"Guest ID        : {G1.guestId}");
                    Console.WriteLine($"Guest Name      : {G1.guestName}");
                    Console.WriteLine($"Assigned Room   : {G1.roomNumber}");
                    Console.WriteLine($"Checkin Date    : {G1.checkInDate}");
                    Console.WriteLine($"Total Nights    : {G1.totalNights}");
                    
                    Console.WriteLine("================================================");
                    
                    
            break;   
                
                
            case "6":
                Console.Write(" Display a sub-menu: (1) Show all available rooms (2) Filter by room type (3) Filter by max price (4) Room price\nstatistics (0) Back: ");
                string choice = (Console.ReadLine());
                switch (choice)
                {
                    case "1":
                        List<Room> availabelRooms = rooms.Where(b => b.isAvailable).OrderByDescending(b => b.pricePerNight).ToList();
                        if (availabelRooms.Count == 0)
                        {
                            Console.WriteLine("No rooms found for the selected criteria");
                        }
                        else
                        {
                            foreach (Room i in availabelRooms)
                            {
                                Console.WriteLine(i.roomNumber);
                            }

                        }

                        break;
                    case "2":
                        Console.Write(" enter the room type:");
                        string roomType = Console.ReadLine();
                        List<Room> theType = rooms.Where(b => b.roomType == roomType).ToList();
                        if (theType.Count == 0)
                        {
                            Console.WriteLine("No rooms found for the selected criteria.'");
                        }
                        else
                        {
                            Console.WriteLine($"number of rooms with type:{roomType} = {theType.Count}");
                            foreach (Room i in theType)
                            {
                                Console.WriteLine(i.roomNumber);
                            }
                        }

                        break;
                    
                    case"3":
                        Console.Write(" enter the maximum price to pay: ");
                        double maxPrice = double.Parse(Console.ReadLine());
                        List<Room> roomPrice = rooms.Where(b => b.isAvailable && b.pricePerNight <= maxPrice).ToList();
                        if (roomPrice.Count == 0)
                        {
                            Console.WriteLine("No rooms found for the selected criteria.");
                        }
                        else
                        {
                            foreach (Room i in roomPrice)
                            {
                                Console.WriteLine(i.roomNumber);
                            }
                        }

                        break;
                    
                    case "4":
                        Console.WriteLine($"the total number of rooms in this hotel: {rooms.Count}");
                        availabelRooms = rooms.Where(b => b.isAvailable).ToList();
                        
                        Console.WriteLine($"the available rooms: {availabelRooms.Count()}");
                        if (availabelRooms.Count == 0)
                        {
                            Console.WriteLine("No rooms found for the selected criteria");
                        }
                        else
                        {
                            Console.WriteLine(
                                $"the average price of this hotel rooms: {rooms.Average(b => b.pricePerNight):f2}");
                            Console.WriteLine(
                                $"the cheepest price of this hotel rooms: {rooms.Min(b => b.pricePerNight):f2}");
                            Console.WriteLine(
                                $"the cheepest price of this hotel rooms: {rooms.Max(b => b.pricePerNight):f2}");
                        }

                        break;
                }
                break;

                
                
                
                
                
                }
                
            }

            

        }
        
        
        
    }
