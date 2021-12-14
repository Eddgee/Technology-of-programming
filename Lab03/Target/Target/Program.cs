public class Target
{
    static void Main(string[] args)
    {
        // мишень из первого варианта

        Random rnd = new Random();
        int a = rnd.Next(-5, 5);   // х центра мишени
        int b = rnd.Next(-5, 5);  // у центра мишени
        int[] x = new int[10];     // массив координат по х
        int[] y = new int[10];     // массив координат по y
        int h, j;  // коэффициенты для помех
        int score = 0;
        Console.WriteLine("Target initialised. You will have 10 shots");
        for (int i = 0; i < 10; i++)
        {
            h = rnd.Next(-1, 1);
            j = rnd.Next(-1, 1);
            Console.WriteLine("Shot {0}: enter x and y: ", i + 1);
            var shot = Console.ReadLine()?.Split().Select(int.Parse).ToList();
            x[i] = (int) shot[0] + h;
            y[i] = (int) shot[1] + j;
            if (Math.Pow(x[i] - a, 2) + Math.Pow(y[i] - b, 2) <= 1)
            {
                Console.WriteLine("Perfect shot!");
                score += 10;
            } else if (Math.Pow(x[i] - a, 2) + Math.Pow(y[i] - b, 2) <= 4)
            {
                Console.WriteLine("Decent shot!");
                score += 5;
            } else
            {
                Console.WriteLine("Whoops");
            }
        }
        

        Console.WriteLine("Result: {0}. Coordinates were {1} and {2}", score, a, b);
    }
}