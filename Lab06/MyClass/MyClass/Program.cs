
    public class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new();
            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2018);
            Book.SetPrice(12);
            b1.Print();
            Console.WriteLine("\n Итоговая стоимость аренды: {0} p.", b1.PriceBook(3));
            Book.SetPrice(5);
            b1.Print();
        Console.WriteLine("\n Итоговая стоимость аренды: {0} p.", b1.PriceBook(3));

        // упражнение 2
        Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013);
        b2.Print();

        Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
        b3.Print();

        // упражнение 3 (про треугольник)

        Triangle t1 = new Triangle(3, 4, 5);      // создаём обычный египетский треугольник
        t1.Print();
        Console.WriteLine("Существует? {0} \nПериметр = {1}\nПлощадь = {2}", t1.Exists(), t1.Perimeter(), t1.Area());
        try
        {
            Triangle t2 = new Triangle(10, 2, 7); // создаём несуществующий треугольник
            t2.Print();
            Console.WriteLine("Существует? {0} \nПериметр = {1}\nПлощадь = {2}", t2.Exists(), t2.Perimeter(), t2.Area());
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}