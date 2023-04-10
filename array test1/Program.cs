internal class Program
{
    private static void Main(string[] args)
    {
        int i;

        string[] cars = { "Dacia", "Aro", "DAC", "Marta" };

        int[] myNum = { 1310, 240, 665, 415 };
        for (i = 0; i < 1; i++)
        {
            Console.Write(cars[0]);
            Console.Write("  ");
            Console.WriteLine(myNum[0]);
            Console.Write(cars[1]);
            Console.Write("  ");
            Console.WriteLine(myNum[1]);
            Console.Write(cars[2]);
            Console.Write("  ");
            Console.WriteLine(myNum[2]);
            Console.Write(cars[3]);
            Console.Write("  ");
            Console.WriteLine(myNum[3]);
        }

    }
}