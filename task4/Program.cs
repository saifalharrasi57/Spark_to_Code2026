namespace task4;

class Program
{
    //task1
    static void PrintWelcome(string username)
    {
        Console.Write($"welcome to spark to code mr{username}");
    }
    
    
    // task2
    static double sqr(int value)
    {
        double result = Math.Pow(value, 2);
        Console.Write($" the result is!!!!  {result}");
        return result;
    }
    
    
    // // task3
    static double CelsiusToFahrenheit(double C)
    {
        double result = (C * 9 / 5) + 32;
        return result;
    }
    
    // task4
    static void DisplayMenu()
    {
        Console.WriteLine("1) Start, 2) Help, 3) Exit");
    }
    
    // task5
    static bool IsEven(int value)
    {
        bool even = (value % 2 == 0);
        return even;
    }
    
    
    // task 6

    static double CalculateArea(double length, double width)
    {
        return length * width;
    }
    static double CalculatePerimeter(double length, double width)
    {
        return 2 *( length + width) ;
    }
    // task7
    static string GetGradeLetter(int grade)
    {
        if (grade >= 85)
        {
            return "A";
        }
        else if (grade >= 75)
        {
            return "B";
        }
        else if (grade >= 60)
        {
            return "C";
        }
        else if(grade>=50)

        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
    
    static void Main(string[] args)
    {
        // Console.Write("dear user , enter your name ");
        // string user_name = Console.ReadLine();
        // PrintWelcome(user_name);
        
        
       //  Console.Write("dear user cn you insert a number to see it's square");
       // int number = int.Parse(Console.ReadLine());
       //  double result = sqr(number);
       //  
       
       // Console.Write("dear user , could you please insert the temprature in Celsius ( btw must be in double e.g 2.7 : ");
       //
       //     double temp = double.Parse(Console.ReadLine());
       //     Console.WriteLine($"in fahrenhiet {CelsiusToFahrenheit(temp)}");
       //
       
       //
       // DisplayMenu();
       
       // Console.Write(" dear user enter even nember ");
       // int number = int.Parse(Console.ReadLine());
       // if (IsEven(number))
       // {
       //     Console.WriteLine("even");
       // }
       // else
       // {
       //     Console.WriteLine("odd");
       // }
       
       // Console.Write("dear user to calculate the area of rectangel, please enter the length :" );
       // double length = double.Parse(Console.ReadLine());
       //
       // Console.Write("width as well: ");
       // double width = double.Parse(Console.ReadLine());
       //
       // Console.WriteLine($"the area of the rectangle = {CalculateArea(length, width)}");
       //
       // Console.WriteLine("cool, now let's try the perimeter");
       // Console.WriteLine($"the perimeter  of the rectangle = {CalculatePerimeter( length, width)}");
       
       Console.Write("dear student, enter your mark , to see your grade:");
       int mark = int.Parse(Console.ReadLine());
       Console.WriteLine($" your grade ragarding your mark is {GetGradeLetter( mark) }");











    }
}
