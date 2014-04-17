using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessNumber();
                Console.ReadKey();
        }
        //This function will have the Computer choose one random number
        //Then ask the player to gueess that number until guessed correctly.
        //After correct answer. CPU will post how many tries to correct answer.
        static void GuessNumber()
        {
            var random = new Random(); 
            var cpuNum = random.Next(0,100); //Var = cpu selection
            var playerNum = 0; //var = player attempts
            Console.WriteLine("Ready to play GUESS THAT NUMBER?!?! Choose your 1st number (1-100)!");
            var input = Console.ReadLine();
            var isNum = Convert.ToInt32(input); //Converts player string to int.
            while (isNum != cpuNum) //While player choice doesnt = cpu choice, loop will keep running
            {
                if (isNum < cpuNum) //if player choice is less, this will run
                {
                    Console.WriteLine("Not quite... Go higher!");
                    //EXTRA CREDIT
                    //When plaayer is way off or near, will display Warmer/Colder
                    if (cpuNum - isNum < 20)
                    {
                        Console.WriteLine("Getting warm!");
                    }
                    if (cpuNum - isNum > 60)
                    {
                        Console.WriteLine("Icey cold! >,<");
                    }
                    input = Console.ReadLine();// Player choice is updated
                    isNum = Convert.ToInt32(input);//Then converted into Int again   
                    playerNum += 1; //Attempt counter +1  
                    
                }
                else if (isNum > cpuNum)// If player choice is more than Cpu choice
                {
                    Console.WriteLine("Ouch, too high! Try again.");//repeat above
                    //EXTRA CREDIT
                    if (isNum - cpuNum < 20)
                    {
                        Console.WriteLine("Getting warm!");
                    }
                    if (isNum - cpuNum > 60)
                    {
                        Console.WriteLine("Icey cold! >,<");
                    }

                    input = Console.ReadLine();
                    isNum = Convert.ToInt32(input);
                    playerNum += 1;
                }
            }
            Console.WriteLine("CONGRATULATIONS!! The number WAS: " + cpuNum); //Player won!! 
            Console.WriteLine("Attempts: " + playerNum); 
            Console.WriteLine(" ");
            //EXTRA CREDIT
            //asks if player would like to play again, then starts function again from beginning
            Console.WriteLine("Would you like to play GUESS THAT NUMBER!! Again?");
            var choice = Console.ReadLine();
            if (choice != "no")
            {
                GuessNumber();
            }
            else
            {
                Console.WriteLine("Thanks for playing! Please get away from me now!");
            }
        }
    }
}
