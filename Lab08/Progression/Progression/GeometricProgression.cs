class GeometricProgression : IProgression
{
    private double startingNumber;
    private double step;
    public GeometricProgression(double start, double step)
    {
        this.startingNumber = start;
        this.step = step;
    }
    public double GetElement(int k)
    {
        return startingNumber * Math.Pow(step, k - 1);
    }
    public double getStartingNumber()
    {
        return startingNumber;
    }
    public double getStep()
    {
        return step;
    }
}
