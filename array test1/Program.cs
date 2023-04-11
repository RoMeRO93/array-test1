internal class Program
{
    private static void Main(string[] args)
    {
        string[] cars = { "Dacia", "Aro", "DAC", "Marta" };
        int[] myNum = { 1310, 240, 665, 415 };

        Console.WriteLine("Car Name".PadRight(10) + "Number".PadLeft(5));
        Console.WriteLine("".PadRight(15, '-'));

        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine($"{cars[i],-10}" + $"{myNum[i],5}");
        }
    }
}
