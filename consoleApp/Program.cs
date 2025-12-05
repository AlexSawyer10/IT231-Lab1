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
        
        Console.WriteLine(integer1);
        Console.WriteLine(integer2);
    }
}