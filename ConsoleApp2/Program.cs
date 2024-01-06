namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(a - b, 2));
        }
    }
}
