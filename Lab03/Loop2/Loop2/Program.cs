public class Loop
{
    static void Main(string[] args)
    {
        double x, x1, x2, y;

        Console.WriteLine("x1 = ");
        x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("x2 = ");
        x2 = double.Parse(Console.ReadLine());

        x = x1;
        while (x <= x2)
        {
            y = Math.Sin(x);
            Console.WriteLine("Для х = {0} sin(x) = {1}", x, y);
            x = x + 0.01;
        }



        int a, b, temp;

        Console.WriteLine("a = ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("b = ");
        b = int.Parse(Console.ReadLine());

        temp = a;
        do
        {
            a = temp;
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            temp = a - b;
            a = b;
        } while (temp != b);

        Console.WriteLine("Result: {0}", a);
    }
}