namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find harmonic number:");

            int n = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += 1 /(double) i;
            }
            Console.WriteLine($"The harmonic value is: {result}");
        }
    }
}