public class Loop
{
    static void Main(string[] args)
    {
        int i, k, m, s;

        Console.WriteLine("k = ");
        k = int.Parse(Console.ReadLine());
        Console.WriteLine("m = ");
        m = int.Parse(Console.ReadLine());

        s = 0;

        for (i = 1; i <= 100; i++)
        {
            if (i > k && i < m) continue;
            s += i;
        }

        Console.WriteLine("Result: {0}", s);
    }
}