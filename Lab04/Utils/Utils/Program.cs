using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        // часть 1 (больше/меньше)

        int x;
        int y;

        Console.WriteLine("Введите первое число:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        y = int.Parse(Console.ReadLine());
        int greater = Utils.Utils.Greater(x, y);
        Console.WriteLine("Большим из чисел {0} и {1} является {2} ", x, y, greater);

        // часть 2 (свап)

        Console.WriteLine("До swap: \t" + x + " " + y);
        Utils.Utils.Swap(ref x, ref y);
        Console.WriteLine("После swap: \t" + x + " " + y);

        // часть 3 (факториал)

        int f;
        bool ok;
        Console.WriteLine("Number for factorial:");
        x = int.Parse(Console.ReadLine());
        // Test the factorial function
        ok = Utils.Utils.Factorial(x, out f);
        // Output factorial results
        if (ok)
            Console.WriteLine("Factorial(" + x + ") = " + f);
        else
            Console.WriteLine("Cannot compute this factorial");

        // часть 4 (площадь треугольника)

        Console.WriteLine("Посчитаем площадь треугольника");
        try {
            double area;
            Console.WriteLine("Треугольник равносторонний? (да/нет)");
            string yesno = Console.ReadLine();
            if (yesno == "да")
            {
                Console.WriteLine("Введите сторону i: ");
                double i = double.Parse(Console.ReadLine());
                Utils.Operation.Area(i, out area);
                Console.WriteLine("Успешно, ответ: {0}", area);
            }
            else
            {
                Console.WriteLine("Введите сторону a: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите сторону b: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите сторону c: ");
                double c = double.Parse(Console.ReadLine());
                if (Utils.Operation.Area(a, b, c, out area))
                {
                    Console.WriteLine("Успешно, ответ: {0}", area);
                }
                else
                    Console.WriteLine("Треугольник не существует");
            }
        } catch (Exception e)
        {
            Console.WriteLine("Ошибка ввода");
        }
        

        // часть 5 (корни квадратного уравнения)

        Console.WriteLine("Решим квадратное уравнение");
        try
        {
            Console.WriteLine("Введите сторону a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону c: ");
            double c = double.Parse(Console.ReadLine());
            double x1, x2;
            int res = Utils.Operation.Roots(a, b, c, out x1, out x2);
            if (res == -1)
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет.", a, b, c);
            else if (res == 0)
                Console.WriteLine("Корень уравнения с коэффициентами a = {0}, b = {1}, c = {2} одинаковы: x1 = x2 = {3}", a, b, c, x1);
            else
            {
                Console.WriteLine("Корень уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны x1 = {3}, x2 = {4}", a, b, c, x1, x2);
            }
                
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Произошло деление на 0. Проверьте значение переменной а");
        }
        catch (Exception e)
        {
            Console.WriteLine("Непредвиденная ошибка: ", e.Message);
        }
        
    }
}