namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = 2;
            Console.WriteLine("Enter the power value:");
            int power = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < power; i++)
            {
                baseNumber = baseNumber * 2;
            }
            Console.WriteLine(baseNumber);
        }
    }
}