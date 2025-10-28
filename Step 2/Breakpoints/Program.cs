namespace Breakpoints;

internal class Program
{
    public static void Main(string[] args)
    {
        var instruments = CreateInstrumentArray(1000);
        int count = 1;

        foreach (var instrument in instruments)
        {
            if (instrument.Weight > 15)
            {
                Console.Write($"Reached an instrument that weighs more than 15 ");
                Console.Write($"on Iteration #{count}.");
                Console.WriteLine("");
            }
            else
            {
                Console.Write($"Reached an instrument that weighs less than 15 ");
                Console.Write($"on Iteration #{count}.");
                Console.WriteLine("");
            }
            count++;
        }
    }

    public class MusicalInstrument
    {
        public int StringCount { get; set; }
        public int Weight { get; set; }
    }
    public static MusicalInstrument[] CreateInstrumentArray(int size)
    {
        var instrumentArray = new MusicalInstrument[size];
        var Random = new Random();

        for (int i = 0; i < size; i++)
        {
            instrumentArray[i] = new MusicalInstrument
            {
                StringCount = Random.Next(3, 6),
                Weight = Random.Next(7, 20)
            };
        }

        return instrumentArray;
    }
}