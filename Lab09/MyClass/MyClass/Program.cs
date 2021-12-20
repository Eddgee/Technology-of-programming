public class Program
    {
        static void Main(string[] args)
        {
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14));

            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013, 101, true);
            b2.TakeItem();
            b2.Print();

            Audit.RunAudit();

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.TakeItem();
            mag1.Print();
            mag1.Subs();
            mag1.Print();
            

            Book b1 = new Book("Харпер Ли", "Убить пересмешника", publ, 800, 1990, 149, false);
            Book b3 = new Book("Вальтер Скотт", "Айвенго", publ, 450, 1690, 28, false);
            Audit.StopAudit();
            Magazine mag2 = new Magazine("Вокруг света", 3, "Земля и мы", 2012, 1468, true);
            mag2.Subs();

            List<Item> itlist = new List<Item>();
            itlist.AddRange(new Item[] { b1, b2, b3, mag1, mag2 });
            itlist.Sort();
            Console.WriteLine("\nСортировка по инвентарному номеру");
            foreach (Item x in itlist)
            {
                x.Print();
            }


    }
}