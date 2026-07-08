namespace task5;

class Program
{
    static void Main(string[] args)
    {
        //task1
        // int[] grades = new int[5];
        // for (int i = 0; i < 5; i++)
        // {
        //     Console.Write("DEAR student, enter your semester grade: ");
        //     int grade = int.Parse(Console.ReadLine());
        //     grades[i] = grade;
        //
        //
        // }
        //
        // foreach (int M in grades)
        // {
        //     Console.WriteLine($"student grades is {M} ");
        //     
        // }
        
        //task2
        // List<string> tasks = new List<string>();
        // for (int i = 0; i < 5; i++)
        // {
        //     Console.Write("dear user, enter 1 task at once ");
        //     string task = Console.ReadLine();
        //     tasks.Add(task);
        //     
        // }
        //
        // foreach (string task  in tasks)
        // {
        //     Console.WriteLine(task);
        // }
        // task3

        // Stack<String> urls = new Stack<string>();
        // for (int i = 0; i < 3; i++)
        // {
        //     Console.Write("dear user,enter url ");
        //     string url = Console.ReadLine();
        //     urls.Push(url);
        // }
        // Console.Write(urls.Pop());
        //
        
        
        // task4
        Queue<string> customers = new Queue<string>();
        for (int i = 0; i < 3; i++)
        {
            Console.Write("dear customer , please enter your name ");
            string customer = Console.ReadLine();
            customers.Enqueue(customer);
        }
        Console.Write($"the first costumer to be served is : {customers.Dequeue()}");




    }
}