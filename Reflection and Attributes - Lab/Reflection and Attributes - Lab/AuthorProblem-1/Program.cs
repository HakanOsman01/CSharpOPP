﻿namespace AuthorProblem_1
{
    [Author("Victor")]
    public class StartUp
    {
        [Author("George")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();

        }
    }
}