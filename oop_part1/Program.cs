using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;

namespace oop_part1;



public class BankAccount
{
    public int accountnumber;
    public string holdername;
    public double balance;


    public void Deposit(double amount)
    {
        balance += amount;
        SendEmail();
        
    }

    public void Withdraw(double amount)
    {
        if (balance < amount)
        {
            Console.WriteLine("the withdraw amount is larger than the  balance");
        }
        else
        {
            balance -= amount;
            SendEmail();
        }
        
    }

    public double CheckBalance()
    {
        PrintInformation();
        return balance;
    }

    private void PrintInformation()
    {
        Console.WriteLine($"account holdername:{holdername}");
        Console.WriteLine($"account balance: {balance}");
        
    }

    private void SendEmail()
    {
        Console.WriteLine($"[Notification] An email update has been sent to the account holder for Account #{accountnumber}.");
    }
    
}


class student
{
    public int grade;
    public string name;
    public string address;
    private string email;
    private int age;

    private void registration(string email)
    {
        this.email = email; // we did this , becuase we want to store the value of object email, remember we can't assing it in the main function
        SendEmail();
    }

    private void SendEmail()
    {
        Console.WriteLine($"[Notification] A registration email has been simulated/sent.");
    }
    
}

class product
{
    public string ProductName;
    public double price;

    public int StackQuantity;

    public void Sell(int quantity)
    {
        if (StackQuantity < quantity)
        {
            Console.WriteLine("not enough stock");
            LogTransaction();
        }
        else
        {
            StackQuantity -= quantity;
            LogTransaction();
        }
    }

    public void Restock(int quantity)
    {
        StackQuantity += quantity;
        LogTransaction();
    }

    public double GetInventoryValue()
    {
        PrintDetails();
        return (price * StackQuantity);
    }


    private void PrintDetails()
    {
        Console.WriteLine($"product name :{ProductName}");
        Console.WriteLine($"product price: {price}");
        Console.WriteLine($"StockQuantity of the product: {StackQuantity}");
        
    }

    private void LogTransaction()
    {
        Console.WriteLine($"[System Log] Transaction recorded for {ProductName}. Current Stock: {StackQuantity} units.");
    }
}

class Program
{
    static void Main(string[] args)
    {

        BankAccount b1 = new BankAccount();
        b1.accountnumber = 1163;
        b1.holdername = "karim";
        b1.balance = 120;
        
        BankAccount b2 = new BankAccount();
        b2.accountnumber = 15203;
        b2.holdername = "Ali";
        b2.balance = 63;

        student s1 = new student();
        s1.grade = 65;
        s1.name = "Ali";
        s1.address = "Muscat";
        
        student s2 = new student();
        s2.name = "Ahmed";
        s2.address = "Muscat";
        s2.grade = 70;


        product p1 = new product();
        p1.ProductName= "Wireless Mouse";
        p1.StackQuantity = 50;
        p1.price = 5.500;
        
        product p2 = new product();
        p2.ProductName = "Mechanical Keyboard";
        p2.price = 15.570;
        p2.StackQuantity = 20;

        bool choice = true;
        while (choice)
        {
            // 1. Display the options to the user
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. View Account Details");
            Console.WriteLine("2. Update Student Address");
            Console.WriteLine("3. Make a Deposit");
            // ... list out the rest of your cases here ...
            Console.WriteLine("20. Exit");
            Console.Write("Enter your choice (1-20): ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("enter the accountNumber: ");
                    int account = int.Parse(Console.ReadLine());
                    if (account == b1.accountnumber)
                    {
                        b1.CheckBalance();
                    }

                   else if (account == b2.accountnumber)
                   {
                       b2.CheckBalance();
                   }
                   else
                   {
                       Console.WriteLine("invalid input, such account doesn't exist");
                   }
                    break;
                case "2":
                    Console.Write("enter the name of the student: ");
                    string name = Console.ReadLine();
                    if (name == s1.name)
                    {
                        Console.Write("enter the new address:");
                        s1.address = Console.ReadLine();
                    }
                    else if(name==s2.name)
                     {
                    Console.Write("enter the new address:");
                    s2.address = Console.ReadLine();
                     }
                    else
                    {
                        Console.WriteLine("invalid input, such a name doesn't exist");
                    }
                    break;
                
                   
                   
                   
            }
        }










    }
}