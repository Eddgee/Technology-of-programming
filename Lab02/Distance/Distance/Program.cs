public class Program
{	
	public struct Distance
		{
			public int foot;
			public int inch;
		}
	static void Main(string[] args)
	{
		Distance d1;
		Distance d2;
		Distance d3;

		try
		{
			Console.Write("Enter foot number for distance 1: ");
			d1.foot = int.Parse(Console.ReadLine());

			Console.Write("Enter inch number for distance 1: ");
			d1.inch = int.Parse(Console.ReadLine());

			Console.Write("Enter foot number for distance 2: ");
			d2.foot = int.Parse(Console.ReadLine());

			Console.Write("Enter inch number for distance 2: ");
			d2.inch = int.Parse(Console.ReadLine());

			int temp = d1.inch + d2.inch;    // сумма дюймов

			d3.foot = d1.foot + d2.foot + (int)(temp / 12);
			d3.inch = temp % 12;

			Console.Write("Answer: {0} '- {1}\"", d3.foot, d3.inch);
		}
		catch (FormatException e)
		{
			Console.WriteLine("An format exception was thrown: {0}",
			e.Message);
		}
		catch (Exception e)
		{
			Console.WriteLine("An exception was thrown: {0}", e.Message);
		}
	}
}