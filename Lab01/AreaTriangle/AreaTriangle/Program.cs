try {
    Console.WriteLine("Введите длину стороны треугольника");
    string temp = Console.ReadLine();
    int i = Int32.Parse(temp);
    double p = i * 3 / 2;  // полупериметр
    Console.WriteLine("Сторона   Площадь");
    double area = Math.Sqrt(p * Math.Pow((p - i), 3));
    Console.WriteLine("{0}       {1}", i, area);
} catch (FormatException e) {
    Console.WriteLine("A format exception was thrown: {0}",
    e.Message);
} catch (DivideByZeroException e) {
    Console.WriteLine("A DivideByZero exception was thrown: {0}",
    e.Message);
} catch (Exception e) {
    Console.WriteLine("An exception was thrown: {0}", e.Message);
}