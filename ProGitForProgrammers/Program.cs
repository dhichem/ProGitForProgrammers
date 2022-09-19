using System;

namespace ProGitForProgrammers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ProGitProgrammers!");
            Console.WriteLine("This is a test message!");
            Console.WriteLine("we added this line to show the staging area!");
        }

        public class Book 
        {
            public string Title {get; set;}
            public List<string> Authors {get; set;}
            public DateTime PublicationDate {get; set;}
        }
    }
}
