namespace task5;

class Program
{
    static double CalculateAverage(List<int> values)
    {
        int total = 0;
        foreach (int i in values)
        {
            total += i;
        }

        return total / values.Count;
        
    }

    static int FindFirstFailing(List<int> values)
    {
        foreach (int i in values)
        {
            if (i < 60)
            {
                return i;
            }
        }
        
        return  -1 ;

    }

    static Queue<string> RemoveJob(Queue<string> jops,string name )
    {
        while (! jops.Contains(name))
        {
            Console.WriteLine("this is jop is not available try again");
            name = Console.ReadLine();

        }
        Queue<string> ret_queue = new Queue<string>();
        foreach (string i  in jops)
        {
            if (i == name)
            {
                continue;
            }
            ret_queue.Enqueue(i);
            
        }

        return ret_queue;
    }
    static void Main(string[] antrgs)
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
        
        
    //     // task4
    //     Queue<string> customers = new Queue<string>();
    //     for (int i = 0; i < 3; i++)
    //     {
    //         Console.Write("dear customer , please enter your name ");
    //         string customer = Console.ReadLine();
    //         customers.Enqueue(customer);
    //     }
    //     Console.Write($"the first costumer to be served is : {customers.Dequeue()}");
    
    //task5
    // int total = 0;
    // int[] grades = new int[5];
    // for (int i = 0; i < 5; i++)
    // {
    //     Console.Write("dear student, please enter your mark");
    //     int mark = int.Parse(Console.ReadLine());
    //     total += mark;
    //     grades[i] = mark;
    // }
    // grades.Sort();
    // double avg = total / grades.Length;
    // Console.WriteLine($"the lowest grade is {grades[0]}");
    // Console.WriteLine($"the highest grade is {grades[4]}");
    // Console.WriteLine($"the averge of the grades is  {avg}");
//     
//     List<string> items = new List<string>();
//     bool choice = true;
//     while (choice) 
//     {
//         Console.Write("dear user, enter 1 itemat once ");
//         string item = Console.ReadLine().ToLower();
//         if (item == "done")
//         {
//             choice = false;
//         }
//         else
//         {items.Add(item);
//         }
//
//         
//     }
//     foreach (string i in items)
//     {
//         Console.WriteLine(i);
//     }
//
//     Console.Write("dear user , your cart id full, chose 1 item to remove: ");
//     string remove = Console.ReadLine();
//     items.Remove(remove);
//     foreach (string i in items)
//     {
//         Console.WriteLine(i);
//     }
//
//         //task9
//         List<int> grades = new List<int>();
//         Console.Write("dear user, how many grades do you wanna insert");
//         int num_grades = int.Parse(Console.ReadLine());
//         for (int i = 0; i < num_grades; i++)
//         {
//             Console.Write("enter the grades 1 by 1:");
//             int grade = int.Parse(Console.ReadLine());
//             grades.Add(grade);
//            
//         }
//         Console.WriteLine($"the average of your grades , dear student is: {CalculateAverage(grades)}");
//         Console.WriteLine($" the least grade within your gradelist is {FindFirstFailing(grades)}");

    
        // task10

        Queue<string> print_jops = new Queue<string>();
        bool choice = true;
        while (choice)
        {
            Console.Write("dear user add print job name: ");
            string jop = Console.ReadLine().ToLower();
            if (jop == "done")
            {
                choice = false;
            }
            else
            {
                print_jops.Enqueue(jop);
            }

        }
        Console.Write("enter jop name to be removed : ");
        string rem_jop= Console.ReadLine().ToLower();
        print_jops = RemoveJob(print_jops, rem_jop);
        Console.WriteLine(" the remaining jops are:");
        foreach (string i in print_jops)
        {
            Console.WriteLine(i);
        }
        {
            
        }


    }
}