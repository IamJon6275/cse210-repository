using System;

class Program
{
    static void Main(string[] args)
    {
        // _continue is set to true so the while loop can run once
        bool _continue = true;
        Scripture s = new Scripture("Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.");
        
        // Greet the user
        Console.WriteLine("Welcome to the Journal Program!");

        // While loop to call the different classes and loop the program until the user decides to quit
        while (_continue)
        {
            s.DisplayScripture();
            Console.WriteLine("Please press enter to continue:");

            string response = Console.ReadLine();
            if (response == "q")
            {
                _continue = false;
            }
            Console.Clear();
        }
    }
}