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
            while(isNum != cpuNum) //While player choice doesnt = cpu choice, loop will keep running
            {
                if (isNum < cpuNum) //if player choice is less, this will run
                {
                    Console.WriteLine("Not quite... Go higher!");
                    input = Console.ReadLine();
                    isNum = Convert.ToInt32(input);
                    playerNum +=1;
                }
                if (isNum > cpuNum)
                {
                    Console.WriteLine("Ouch, too high! Try again.");
                    input = Console.ReadLine();
                    isNum = Convert.ToInt32(input);
                    playerNum +=1;
                }
                
            }
                    Console.WriteLine("CONGRATULATIONS!! The number WAS: " + cpuNum);
                    Console.WriteLine("Attempts: " + playerNum);
                
            
        }
    }
}
