class Triangle
{
    private double a;
    private double b;
    private double c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    //public Triangle()
    //{ }

    public bool Exists()
    {
        double max = Math.Max(a, Math.Max(b, c));
        return max < (a + b + c - max);
    }

    public void Print()
    {
        Console.WriteLine(this);
    }

    public double Perimeter()
    {
        if (Exists()) 
            return a + b + c;
        else
            throw new Exception("Треугольник не существует");
    }

    public double Area()
    {
        if (Exists())
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        else
            throw new Exception("Треугольник не существует");
    }

    public override string ToString()
    {
        string bs = String.Format("\nТреугольник:\n Сторона a: {0}\n Сторона b: {1}\n Сторона c: {2}\n",
            a, b, c);
        return bs;
    }
}
