abstract class Progression
{
    protected double startingNumber;   // начальный элемент прогрессии
    protected double step;          // шаг прогрессии
    public abstract double GetElement(int k);

    public double getStartingNumber()
    {
        return startingNumber;
    }
    public double getStep()
    {
        return step;
    }

}
