namespace PracticeWeek1;
// This program is simply practice focusing the Week 1's lessons
// Currently programming a personal take on the rock-paper-scissors practice from 11/16/2022
class Rock_Paper_Scissors
{
    static void Main()
    {
        Random rand = new Random();
        int pcInput = rand.Next(1,4);

        Console.WriteLine("Welcome to the classic game, rock - paper - scissors! When ready, input your numeric choice below:\n"); //Intro + prompts user
        Console.WriteLine("Rock\t[1]\nPaper\t[2]\nScissors[3]\n");
        int userInput = int.Parse(Console.ReadLine()); //Read user input (string) and save as an int for userInput var

        //Switch statement to clarify to user the choice they made
        switch (userInput){
            case 1:
            Console.WriteLine("\nYou chose rock!");
            break;
            case 2:
            Console.WriteLine("\nYou chose paper!");
            break;
            case 3:
            Console.WriteLine("\nYou chose scissors!");
            break;
            default:
            Console.WriteLine("\nInvalid input, please restart the game");
            break;
        }

        //Switch statement to inform user what Cortana chose
        switch (pcInput){
            case 1:
            Console.WriteLine("\nCortana chose rock!");
            break;
            case 2:
            Console.WriteLine("\nCortana chose paper!");
            break;
            case 3:
            Console.WriteLine("\nCortana chose scissors!");
            break;
            default:
            Console.WriteLine("\nWhat happened??");
            break;
        }

        //if else if else structure that determines outcome of user and pc choice
        if (userInput.Equals(1) && pcInput.Equals(3) ||
            userInput.Equals(2) && pcInput.Equals(1) ||
            userInput.Equals(3) && pcInput.Equals(2) )
        {
            Console.WriteLine("\nYou win! Congrats!");
        }
        else if (userInput == pcInput)
        {
            Console.WriteLine("\nLooks like it's a tie!");
        }
        else 
        {
            Console.WriteLine("\nOh no! You lost, better luck next time!");
        }
    }
}
