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
        
       DoAdd(integer1, integer2);
    }

    public static void DoAdd(int int1, int int2)
    {
        double added = int1 + int2;
        
        Console.WriteLine(added);
    }
    
    
}