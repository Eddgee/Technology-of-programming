public class Years
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the year: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        } catch (FormatException e)
        {
            Console.WriteLine("An format exception was thrown: {0}",
            e.Message);
        } catch (Exception e)
        {
            Console.WriteLine("An exception was thrown: {0}", e.Message);
        }
    }
}