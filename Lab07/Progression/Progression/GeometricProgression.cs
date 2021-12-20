class GeometricProgression : Progression
{
    public GeometricProgression(double start, double step)
    {
        this.startingNumber = start;
        this.step = step;
    }
    public override double GetElement(int k)
    {
        return startingNumber * Math.Pow(step, k - 1);
    }
}
