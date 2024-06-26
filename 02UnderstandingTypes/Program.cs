using System.Numerics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Type\t\tSize(Bytes)\tMinimum\t\t\tMaximum");
        Console.WriteLine($"sbyte\t\t{sizeof(sbyte)}\t{sbyte.MinValue}\t\t\t{sbyte.MaxValue}");
        Console.WriteLine($"byte\t\t{sizeof(byte)}\t{byte.MinValue}\t\t\t{byte.MaxValue}");
        Console.WriteLine($"short\t\t{sizeof(short)}\t{short.MinValue}\t\t\t{short.MaxValue}");
        Console.WriteLine($"ushort\t\t{sizeof(ushort)}\t{ushort.MinValue}\t\t\t{ushort.MaxValue}");
        Console.WriteLine($"int\t\t{sizeof(int)}\t{int.MinValue}\t\t{int.MaxValue}");
        Console.WriteLine($"uint\t\t{sizeof(uint)}\t{uint.MinValue}\t\t\t{uint.MaxValue}");
        Console.WriteLine($"long\t\t{sizeof(long)}\t{long.MinValue}\t{long.MaxValue}");
        Console.WriteLine($"ulong\t\t{sizeof(ulong)}\t{ulong.MinValue}\t\t\t{ulong.MaxValue}");
        Console.WriteLine($"float\t\t{sizeof(float)}\t{float.MinValue}\t{float.MaxValue}");
        Console.WriteLine($"double\t\t{sizeof(double)}\t{double.MinValue}\t{double.MaxValue}");
        Console.WriteLine($"decimal\t\t{sizeof(decimal)}\t{decimal.MinValue}\t{decimal.MaxValue}");
        
        Console.WriteLine("Enter the number of centuries:");
        int centuries = int.Parse(Console.ReadLine());
        
        int years = centuries * 100;
        int days = years * 365; // Simplified model, ignoring leap years
        int hours = days * 24;
        long minutes = hours * 60L;
        long seconds = minutes * 60L;
        BigInteger milliseconds = seconds * 1000;
        BigInteger microseconds = milliseconds * 1000;
        BigInteger nanoseconds = microseconds * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    
    }
}