using System;

public class Test{

    /*
    int b - total number of rocks in bag, this will be between 0-1000
    int s - number of rocks Steve will take out every turn, rand between 0-1000
    int t - number of rocks Tommy will take out every turn, rand between 0-1000
    */
    public static int rockGame(int b, int s, int t){
        //WRITE YOUR CODE HERE

        int SteveTotal =+ s;
        int TommyTotal =+ t;

    do 
      {
        if (b > 0)
        {
            b -= s;
            b -= t;
        }
        else if ((b - s) <= 0)
        {

            return(SteveTotal);
        }
        else if ((b - t) <= 0)
        {
            return(TommyTotal);
        }
      } while ()

    }


    //DO NOT TOUCH THE CODE BELOW
    public static void Main(){
        int b = int.Parse(Console.ReadLine()); //Bag
        int s = int.Parse(Console.ReadLine()); //Steve
        int t = int.Parse(Console.ReadLine()); //Tommy
        Console.WriteLine(rockGame(b,s,t));
    }
}