using System;

class Program
{
    static void Main(string[] args)
    {
        // _continue is set to true so the while loop can run once
        bool _continue = true;
        Scripture s = new("Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.");
        
        // Greet the user
        Console.WriteLine("Welcome to the Journal Program!");

        // While loop to call the different classes and loop the program until the user decides to quit
        while (_continue)
        {
            Console.WriteLine("Please select one of the following choices (1-4 for a scripture, q to quit):");
            Console.WriteLine("1. John 14:6 Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.");
            Console.WriteLine("2. 1 Nephi 3:7-9 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord" +
            "hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may" +
            "accomplish the thing which he commandeth them. And it came to pass that when my father had heard these words he was exceedingly glad, for he" +
            "knew that I had been blessed of the Lord. And I, Nephi, and my brethren took our journey in the wilderness, with our tents, to go up to the land of Jerusalem.");
            Console.WriteLine("3. Proverbs 16:3 Commit to the Lord whatever you do, and your plans will succeed");
            Console.WriteLine("4. Random scripture");
            Console.WriteLine("q. to quit");
            Console.Write("What would you like to do? ");

            r.DisplayReference();
            s.DisplayScripture();
            Console.WriteLine("\nPlease press enter to continue:");

            string response = Console.ReadLine();
            if (response == "q")
                {
                    _continue = false;
                }
            Console.Clear();
        }
    }
}