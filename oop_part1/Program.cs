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

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}