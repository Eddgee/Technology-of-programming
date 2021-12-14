public class Loop
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("\nwhile: \t\t");
        int i = 1;
        while (i <= n)
        {
         Console.Write(" " + i);
            i += 2;
        }
        Console.Write("\n");


        double x, x1, x2, y;

        Console.WriteLine("x1 = ");
        x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("x2 = ");
        x2 = double.Parse(Console.ReadLine());

        x = x1;
        do
        {
            y = Math.Sin(x);
            Console.WriteLine("Для х = {0} sin(x) = {1}", x, y);
            x = x + 0.01;
        }
        while (x <= x2);


        int a, b, temp;

        Console.WriteLine("a = ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("b = ");
        b = int.Parse(Console.ReadLine());

        temp = a;
        while (temp != b)
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
        }
        Console.WriteLine("Result: {0}", a);

        // 1 часть лабораторной #5
        int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };
        for (i = 0; i < myArray.Length; i++)
        {
            if (i % 2 == 1)
                Console.Write("{0} ", myArray[i]);
            else
                Console.Write("{0} ", 0);
        }
        Console.Write("\n");

        int[] MyArray;
        Console.WriteLine("n = ");
        n = int.Parse(Console.ReadLine());
        MyArray = new int[n];
        for (i = 0; i < MyArray.Length; ++i)
        {
            Console.Write("a[{0}]=", i);
            MyArray[i] = int.Parse(Console.ReadLine());
        }
        foreach (int xx in MyArray) Console.Write("{0} ", xx);


    }
}