using System;

class Program
{
    static void Main(string[] args)
    {
        // _continue is set to true so the while loop can run once
        bool _continue = true;
        
        // Greet the user
        Console.WriteLine("Welcome to the Mindfullness Program!");

        // While loop to call the different classes and loop the program until the user decides to quit
        while (_continue)
        {
            // Display selection menu
            Console.WriteLine("Please select one of the following choices (1-4 for an activity, q to quit):");
            Console.WriteLine("1. Breathing Activity, breathe in and breathe out as prompted until the timer runs out");
            Console.WriteLine("2. Reflecting Activity, answer as many reflection questions as you can until the timer runs out");
            Console.WriteLine("3. Listing Activity, list as much as you can before the timer runs out given the prompt");
            Console.WriteLine("4. Random activity");
            Console.WriteLine("5. to quit");
            Console.Write("What would you like to do? ");
            int _selector = int.Parse(Console.ReadLine());

            switch (_selector)
            {
                case 1:
                    
                    break;

                case 2:
                    
                    break;

                case 3:
                    
                    break;

                // Select a random scripture
                case 4:
                    Random randomGenerator = new Random();
                    int number = randomGenerator.Next(1, 3);
                    switch (number)
                    {
                        case 1:
                            
                            break;

                        case 2:
                        
                            break;

                        case 3:
                            
                            break;
                    }
                    break;

                // End the program
                case 5:
                    _continue = false;
                    break;
            }                
        }
    }
}