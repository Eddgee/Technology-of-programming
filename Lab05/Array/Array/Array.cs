class Array
{
    public static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(System.Console.ReadLine());
        double[] a = new double[n];
        Input(a);
        Console.WriteLine("Sum of the numbers is {0}", Sum(a));       // a
        Console.WriteLine("Average number is {0}", Average(a));       // b
        Console.WriteLine("Sum of positive numbers is {0}", SumPos(a));       // c
        Console.WriteLine("Sum of negative numbers is {0}", SumNeg(a));       // c
        Console.WriteLine("Sum of even numbers is {0}", SumEven(a));       // d
        Console.WriteLine("Sum of odd numbers is {0}", SumOdd(a));       // d

        int[] maxmin = MaxMin(a);
        Console.WriteLine("The smallest number's index is {0} \nThe biggest number's index is {1}", 
            maxmin[0], maxmin[1]);


        Console.WriteLine("The multiplication of number between the biggest and the smallest is {0}", MultMaxMin(a));

        MaxMin(a);
    }
    private static void Input(double[] a)
    {
        for (int r = 0; r < a.Length; r++)
        {
            Console.Write("Enter value for [{0}]: ", r);
            a[r] = double.Parse(System.Console.ReadLine());
        }
        Console.WriteLine();
    }
    private static double Sum(double[] a)
    {
        double res = 0;
        for (int r = 0; r < a.Length; r++)
        {
            res += a[r];
        }
        return res;
    }
    private static double Average(double[] a)
    {
        return Sum(a) / a.Length;
    }
    private static double SumPos(double[] a)
    {
        double res = 0;
        for (int r = 0; r < a.Length; r++)
        {
            if (a[r] > 0)
            res += a[r];
        }
        return res;
    }
    private static double SumNeg(double[] a)
    {
        double res = 0;
        for (int r = 0; r < a.Length; r++)
        {
            if (a[r] < 0)
                res += a[r];
        }
        return res;
    }
    private static double SumEven(double[] a)   
    {
        // да, 0 - это чётное число, но со стороны пользователя
        // массив начинается с первого числа, а значит a[0] - нечётная позиция
        // аналогичная логика в SumOdd
        double res = 0;
        for (int r = 0; r < a.Length; r++)
        {
            if (r % 2 != 0)
                res += a[r];
        }
        return res;
    }
    private static double SumOdd(double[] a)
    {
        double res = 0;
        for (int r = 0; r < a.Length; r++)
        {
            if (r % 2 == 0)
                res += a[r];
        }
        return res;
    }
    private static int[] MaxMin(double[] a)
    {
        int[] res = new int[2];
        for (int r = 0; r < a.Length; r++)
        {
            if (a[r] < a[res[0]])
                res[0] = r;
            if (a[r] > a[res[1]])
                res[1] = r;
        }
        return res;
    }
    private static double MultMaxMin(double[] a)
    {
        int[] indexes = MaxMin(a);
        int first, last;
        if (indexes[0] < indexes[1])
        {
            first = indexes[0]; 
            last = indexes[1];
        }
        else
        {
            first = indexes[1]; 
            last = indexes[0];
        } 
        double res = 1;
        for (int r = indexes[0] + 1; r < indexes[1]; r++)  // границы не включены
        {
            res *= a[r];
        }
        return res;
    }
}
