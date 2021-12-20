public class Program
{
    static void Main(string[] args)
    {
        GeometricProgression p1 = new GeometricProgression(2, 0.5);      // геом. прогрессия с шагом 0.5
        ArithmeticProgression p2 = new ArithmeticProgression(2, 0.5);    // арифм. прогрессия с шагом 0.5
        Console.WriteLine("Введите номер элемента: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Элемент с номером {0} геометрической прогрессии с шагом {1} и начальным элементом {2} равен {3}",
            n, p1.getStep(), p1.getStartingNumber(), p1.GetElement(5));
        Console.WriteLine("Элемент с номером {0} арифметической прогрессии с шагом {1} и начальным элементом {2} равен {3}",
            n, p2.getStep(), p2.getStartingNumber(), p2.GetElement(5));
    }
}