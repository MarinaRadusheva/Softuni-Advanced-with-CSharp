using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            IStream song = new Music("Arctic monkeys", "Flourescent adolescent", 500, 50);
            IStream file = new File("document", 200, 120);
            StreamProgressInfo songInfo = new StreamProgressInfo(song);
            StreamProgressInfo fileInfo = new StreamProgressInfo(file);
            Console.WriteLine(songInfo.CalculateCurrentPercent()+"%");
            Console.WriteLine(fileInfo.CalculateCurrentPercent()+"%");
        }
    }
}
