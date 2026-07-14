namespace oop_part2;


class Room
{
    public int roomNumber;
    public string roomType;
    public double pricePerNight;
    public bool isAvailable;
    
    
    public Room(string roomType){}


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
    
    
    List<Room> rooms = new List<Room>();
    List<Guest> guests = new List<Guest>();
    
    
    static void Main(string[] args)
    {
     
        
    }
}