namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");
            Random random = new Random();
            Console.WriteLine("Enter the number of times for coin flip");
            int n = Convert.ToInt32(Console.ReadLine());
            int head = 0, tail = 0;
            for (int i = 0; i < n; i++)
            {
                double coinFlipped = random.NextDouble();
                if (coinFlipped < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
            double headPercentage = head * 100 / n;
            Console.WriteLine($"Head won {head} times, Head Score: {headPercentage}%");
            double tailPercentage = tail * 100 / n;
            Console.WriteLine($"Tail won {tail} times, Tail Score: {tailPercentage}%");
        }
    }
}