class ArithmeticProgression : Progression
{
    public ArithmeticProgression(double start, double step)
    {
        this.startingNumber = start;
        this.step = step;
    }
    public override double GetElement(int k)
    {
        return startingNumber + step * (k - 1);
    }
}
