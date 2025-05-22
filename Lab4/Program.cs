namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 50; j++)
            {
                Table table = new Table();
                for (int i = 0; i < 5; i++)
                {
                    new Philosopher(i, table);
                }
            }
        }
    }
}
