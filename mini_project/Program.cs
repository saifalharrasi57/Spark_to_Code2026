using System.Security.Cryptography.X509Certificates;

namespace mini_project;

class Program
{
    
    public static List<string> names = new List<string>();
    public static List<int> account_number = new List<int>();
    public static List<double> balance = new List<double>();




    static void AddAccount()
    {
        Console.Write("dear user , enter your name ");
        string name = Console.ReadLine();

        Console.Write("plus, enter your account number ");
        int account_num = int.Parse(Console.ReadLine());
        if (!account_number.Contains(account_num))
        {
            names.Add(name);
            account_number.Add(account_num);
            Console.Write("enter , initial deposit amount ");
            double deposit_amount = double.Parse(Console.ReadLine());
            if (deposit_amount >= 0)
            {
                balance.Add(deposit_amount);
                Console.WriteLine("here is the customer account info:");
                Console.WriteLine(
                    $" custumer name :{name}, account number: {account_num}: , initial deposit {deposit_amount} :  ");
            }
        }

        else
        {
            Console.WriteLine("error this account , already exist");
        }
        
        
        

    }

    static void WithdrawMoney()
    {
        Console.WriteLine("dear user , enter your account number");
        int account_num = int.Parse(Console.ReadLine());
        int index = account_number.IndexOf(account_num);
        if (! (index == -1))
        {
            Console.Write("dear user,enter the withdrawal amount:");
            double withdrawal_amount = double.Parse(Console.ReadLine());
            if (withdrawal_amount >= 0 && !(withdrawal_amount > balance[index]))
            {
                balance[index] -= withdrawal_amount;
                Console.WriteLine($"the account updated balance= {balance[index]}");
            }
            else
            {
                Console.WriteLine("error, please, enter a positive amount or does not exceed the account current balance ");
            }
        }
        else
        {
            Console.WriteLine("error, entered account does not exist");
        }

    }

    static  void DepositMoney()
    {
        Console.WriteLine("dear user , enter your account number");
        int account_num = int.Parse(Console.ReadLine());
        int index = account_number.IndexOf(account_num);
        if (! (index == -1))
        {
            Console.Write("dear user,enter the deposit amount:");
            double deposit_amount = double.Parse(Console.ReadLine());
            if (deposit_amount >= 0)
            {
                balance[index] += deposit_amount;
                Console.WriteLine($"the account updated balance= {balance[index]}");
            }
            else
            {
                Console.WriteLine("error, enter a positive amount ");
            }
        }
        else
        {
            Console.WriteLine("error, entered account does not exist");
        }
       
    }
    
    
    static void ShowBalance()
    {
        Console.Write("dear user, enter your account number ");
        int account_num = int.Parse(Console.ReadLine());
        int index = account_number.IndexOf(account_num);
        if (! (index == -1))
            
        {
            Console.WriteLine("here is the customer account info:");
            Console.WriteLine($" custumer name :{names[index]}, account number: {account_num}: , initial deposit {balance[index]} :  ");
        }
        else
        {
            Console.WriteLine("error, entered account does not exist");
        }
        
    }


    static void TransferAmount()
    {
        Console.Write("dear user, enter your account number ");
        int account_num1 = int.Parse(Console.ReadLine());
        Console.Write("dear user, enter receiver account number ");
        int account_num2 = int.Parse(Console.ReadLine());
        if (!(account_number.Contains(account_num2) && account_number.Contains(account_num1)))
        {
            Console.WriteLine(" error one of the accounts , do not exists ");
        }
        else
        {
            Console.Write("dear user,enter the transfred  amount:");
            double transferd_amount = double.Parse(Console.ReadLine());
            int index = account_number.IndexOf(account_num1);
            int index2 = account_number.IndexOf(account_num2);
            if (transferd_amount >= 0 && !(transferd_amount > balance[index]))
            {
                balance[index] -= transferd_amount;
                balance[index2] += transferd_amount;
                
                Console.WriteLine($"the sender updated balance= {balance[index]}");
                Console.WriteLine($"the receiver updated balance= {balance[index2]}");

            }

        }
    }
    static void ListAllAccounts()
    {
        if (account_number.Count == 0)
        {
            Console.WriteLine("No accounts found in the system.");
            return;
        }

        Console.WriteLine("\n--- Registered Accounts Directory ---");
        for (int i = 0; i < account_number.Count; i++)
        {
            Console.WriteLine($"Account #: {account_number[i]} | Holder: {names[i]} | Balance: ${balance[i]}");
        }
    }

    // NEW SERVICE 2: Close an Account
    static void CloseAccount()
    {
        Console.Write("dear user, enter the account number to close: ");
        int account_num = int.Parse(Console.ReadLine());
        int index = account_number.IndexOf(account_num);

        if (index != -1)
        {
            Console.WriteLine($"Processing closure for account holder: {names[index]}");
            
            // Remove the elements at the matched index across all 3 lists
            names.RemoveAt(index);
            account_number.RemoveAt(index);
            balance.RemoveAt(index);

            Console.WriteLine("Success! The account has been securely closed.");
        }
        else
        {
            Console.WriteLine("error, entered account does not exist");
        }
    }

    static void Main(string[] args)
    {
        bool exitApp = false;
        while (!exitApp)
        {
            Console.WriteLine("\n===== Welcome to Spark Bank =====");
            Console.WriteLine("1. Add New Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Show Balance");
            Console.WriteLine("5. Transfer Amount");
            Console.WriteLine("6. <your 1st custom service - choose a name>");
            Console.WriteLine("7. <your 2nd custom service - choose a name>");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");
            int choice;
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                continue; // skip the rest of this loop pass, show the menu again
            }
            switch (choice)
            {
                case 1:
                    AddAccount();
                    break;
                case 2:
                     DepositMoney();
                     break;
                case 3:
                    WithdrawMoney();
                    break;
                case 4:
                    ShowBalance();
                    break;
                case 5:
                    TransferAmount();
                    break;
                case 6:
                    ListAllAccounts();
                    break;
                case 7:
                    CloseAccount();
                    break;
                case 8:
                    exitApp = true;
                    Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option, please choose between 1 and 8.");
                    break;
            }
        }
    }
}