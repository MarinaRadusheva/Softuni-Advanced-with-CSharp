using System;

namespace AuthorProblem
{
    [Author("Tisho")]
    public class StartUp
    {
        [Author("Pesho")]
        static void Main(string[] args)
        {

            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}
