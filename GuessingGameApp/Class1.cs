using System;

namespace GuessingGameApp
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number between 0 and 100");
                string s = Console.ReadLine();

                int i = int.Parse(s);
                if (i > winNum)
                {
                    Console.WriteLine("Too High!! Go Below and try try again");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Your too Low!!! Go Higher my dude!!");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You Did it nice job!!!! Winner Winner Chicken Dinner ");
                    win = true;
                }
            } while (win == false);
        }
    }
};
