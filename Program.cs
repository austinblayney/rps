using System;

namespace rock_paper_scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

             Console.WriteLine("Welcome to the game");
              Random random = new Random();
              string[] rps = new string[] { "Rock", "Paper", "Scissors"};
              int comprdm = random.Next(0,2); 
              string compChoice = rps[comprdm];
              
                while (true)
            {
                
            
                    Console.WriteLine("Please guess a number between 1 and 100");
                string userInput = Console.ReadLine();
                string[] userRps = new string[] { "Rock", "Paper", "Scissors"};
int userGuess = userInput. (0,2);
                bool isInt = Int32.TryParse(userInput, out userGuess);
               
                    
    
                }
      
        }
    }
    }

