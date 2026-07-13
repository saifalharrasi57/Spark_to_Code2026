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

    public void Register(string email) 
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
         
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. View Account Details");
            Console.WriteLine("2. Update Student Address");
            Console.WriteLine("3. Make a Deposit");
            Console.WriteLine("6. Register a Student");
            Console.WriteLine("7. Compare Two Account Balances");
            Console.WriteLine("9. Transfer Between Accounts");
            Console.WriteLine("10. Update Student Grade (Validated)");
            Console.WriteLine("14. Scholarship Eligibility Check");
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
                        Console.WriteLine($"the new address is {s1.address} (changes commited)");
                    }
                    else if(name==s2.name)
                     {
                    Console.Write("enter the new address:");
                    s2.address = Console.ReadLine();
                    Console.WriteLine($"the new address is {s2.address} (changes commited)");
                     }
                    else
                    {
                        Console.WriteLine("invalid input, such a name doesn't exist");
                    }
                    break;
                case "3":
                    Console.Write("enter the accountNumber: ");
                     account = int.Parse(Console.ReadLine());
                    Console.Write("enter tme amount to deposit:");
                    double amount = double.Parse(Console.ReadLine());
                    if (account == b1.accountnumber)
                    {
                        b1.Deposit(amount);
                        Console.WriteLine($"account new balance = {b1.balance}");
                    }
                    
                  
                    else if (account == b2.accountnumber)
                    {
                        b2.Deposit(amount);
                        Console.WriteLine($"account new balance = {b2.balance}");
                    }
                    else
                    {
                        Console.WriteLine("invalid input, such account doesn't exist");
                    }

                    break;
                
                case "6":
                    Console.Write("enter the student name:");
                    string stu_name = Console.ReadLine();
                    Console.Write("enter the student e-mail:");
                    string mail = Console.ReadLine();
                    if (stu_name == s1.name)
                    {
                        s1.Register(mail);
                        Console.WriteLine("do not share your e-mail");
                    }
                    else if (stu_name == s2.name)
                    {
                        s2.Register(mail);
                        Console.WriteLine("do not share your e-mail");
                    }
                    else
                    {
                        Console.WriteLine("invalid input, such a name doesn't exist");
                    }
                    break;
                case "7":
                    int result = b1.balance.CompareTo(b2.balance);
                    if (result > 0)
                    {
                        Console.WriteLine($"{b1.holdername} has more money: {b1.balance}");
                    }
                    
                    else if (result == 0)
                    {
                        Console.WriteLine("the two acount has equal amount of money ");
                    }
                    else
                    {
                        Console.WriteLine($"{b2.holdername} has more money: {b2.balance}");
                    }
                    break;
                
                case "9":
                    Console.Write("dear user, enter the your source account");
                    int source = int.Parse(Console.ReadLine());
                    Console.Write("enter the destination account as well");
                    int destination = int.Parse(Console.ReadLine());
                    bool match1 = (b1.accountnumber == source && b2.accountnumber == destination);
                    bool match2=  (b2.accountnumber == source && b1.accountnumber == destination);
                    if (match1 || match2)
                    {
                        Console.Write("dear user, enter the amount to be deposit from the source account:");
                        amount = double.Parse(Console.ReadLine());
                        if (match1)
                        {
                            if (b1.balance < amount)
                            {
                                Console.Write("invalid input, the amount exceeded, the account balance:");
                            }
                            else
                            {
                                b1.Withdraw(amount);
                                b2.Deposit(amount);
                            }
                        }
                        else if (match2)
                        {
                            if (b1.balance < amount)
                            {
                                Console.Write("invalid input, the amount exceeded, the account balance");
                            }
                            else
                            {
                                b2.Withdraw(amount);
                                b1.Deposit(amount);
                            }
                        }

                    }
                    else
                    {
                        
                       Console.WriteLine("invalid input, one of the account's numbers does not exist");
                    }

                    break;
                
                
                
                case "10":
                    try
                    {
                        Console.Write("enter the student name, to update his grade: ");
                        stu_name = Console.ReadLine();
                        if (stu_name.Any(char.IsDigit))
                        {
                            throw new FormatException("Names cannot contain numbers or special characters.");
                        }
                        
                        match1 = stu_name == s1.name;
                        match2 = stu_name == s2.name;

                        if (match1)
                        {
                            Console.WriteLine("enter the student updated grade");
                            int grade = int.Parse(Console.ReadLine());
                            if (grade >= 0 & grade <= 100)
                            {
                                s1.grade = grade;
                            }

                            else
                            {
                                Console.WriteLine("invalid input, as the grade exceeded the permit grade values");
                            }
                        }
                        else if (match2)
                        {
                            Console.WriteLine("enter the student updated grade: ");
                            int grade = int.Parse(Console.ReadLine());
                            if (grade >= 0 & grade <= 100)
                            {
                                s2.grade = grade;
                            }
                            else
                            {
                                Console.WriteLine("invalid input, as the grade exceeded the permit grade values");
                            }
                        }

                        else
                        {
                            Console.WriteLine("invalid input , such a name does not exist");
                        }



                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"error ,{ex.Message}");
                    }break;
                
                
                case "14":
                    choice = true;
                    while (choice)
                    {
                        
                        Console.WriteLine("=== Select a Student ===");
                        Console.WriteLine($"1) {s1.name} (Grade: {s1.grade})");
                        Console.WriteLine($"2) {s2.name} (Grade: {s2.grade})");
                        Console.Write("Enter your choice (1 or 2): ");
                        
                        student selectedStudent = null;
                        string studentInput = Console.ReadLine();
                        
                        if (studentInput == "1")
                        {
                            selectedStudent = s1;
                        }
                        else if (studentInput == "2")
                        {
                            selectedStudent = s2;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection. Defaulting to Student 1.");
                            selectedStudent = s1;
                        }

                        Console.WriteLine(); 
              
                        Console.WriteLine("=== Select a Bank Account ===");
                        Console.WriteLine($"1) {b1.holdername} (Acc: {b1.accountnumber}, Balance: {b1.balance})");
                        Console.WriteLine($"2) {b2.holdername} (Acc: {b2.accountnumber}, Balance: {b2.balance})");
                        Console.Write("Enter your choice (1 or 2): ");

                        BankAccount selectedAccount = null;
                        string accountInput = Console.ReadLine();

                        if (accountInput == "1")
                        {
                            selectedAccount = b1;
                        }
                        else if (accountInput == "2")
                        {
                            selectedAccount = b2;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection. Defaulting to Account 1.");
                            selectedAccount = b1;
                        }

                        Console.WriteLine(); 

  
                        Console.WriteLine($"--- Checking Scholarship for {selectedStudent.name} with {selectedAccount.holdername}'s Account ---");
                        
                        if (selectedStudent.grade >= 80 && selectedAccount.balance >= 100)
                        {
                            Console.WriteLine("Result: Eligible");
                        }
                        else
                        {
                            Console.WriteLine("Result: Scholarship Denied due to the following reason(s):");
                            if (selectedStudent.grade < 80)
                            {
                                Console.WriteLine($"- Student's grade ({selectedStudent.grade}) is below the required 80.");
                            }
                            if (selectedAccount.balance < 100)
                            {
                                Console.WriteLine($"- Account balance ({selectedAccount.balance}) is below the required 100.");
                            }
                        }

                   
                        Console.Write("\nDo you want to check another pair? (y/n): ");
                        string continueChoice = Console.ReadLine().ToLower();
                        if (continueChoice != "y")
                        {
                            choice = false;
                        }
                    }

                    break;
                case "20":
                    Console.WriteLine("\nThank you for using the Bank & Student Management System. Goodbye!");
                    choice = false; 
                    break;

                default:
                    Console.WriteLine("\nInvalid option! Please enter a valid case number between 1 and 20.");
                    break;
            }








                                }
                            }










                        }
                    