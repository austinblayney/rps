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
                
                Console.WriteLine("Rock, Paper, or Scissors?");
                string userInput = Console.ReadLine();
                int guess = 0;
                bool isInt = Int32.TryParse(userInput, out guess);
                   
      
        }
    }
    }
}
