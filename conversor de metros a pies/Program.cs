internal class Program
{
    private static void Main(string[] args)
    {

        int num;

        Console.WriteLine("Longitud de metros:");
        num = int.Parse(Console.ReadLine());
        float resultado = num * 3.281f;

        if (num > 0)
        {
            Console.WriteLine(num + " " + "metros son" + " " + resultado + " " + "pies");
        }
    }

}