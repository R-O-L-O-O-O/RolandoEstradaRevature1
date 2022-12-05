using System;
namespace ExpressionPractice;

public class Program //Create an app that allows two users to take rocks from a bag (0,1000) and count the total from each user
{
    Random rnd = new Random();

    public int RockGame(int b, int k, int d)
    {
        do
        {
            b = rnd.Next(1,1000);

            if (b < 0)
            {

            }
        }
    }

    static void Main(string[] args)
    {
        int k = Int32.Parse(Console.ReadLine);
    }
}