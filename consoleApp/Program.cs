namespace consoleApp;

class Program
{
    static void Main(string[] args)
    {
        int integer1;
        int integer2;
        
        Console.WriteLine("Enter in integer one: ");
        
        integer1 = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Enter in integer two: ");
        
        integer2 = int.Parse(Console.ReadLine()!);


        
        DoMultiply(integer1, integer2);
    }

    
    
    
    
    
    public static void DoMultiply (int int1,int int2)
    {
        int multiplied = int1 * int2;
        
        Console.WriteLine(multiplied);
    }
}

