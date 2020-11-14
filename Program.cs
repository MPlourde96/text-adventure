using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
            first();
        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome to my game!");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
        }
        

        public static void first()
        {
            string choice;

            Console.WriteLine("You wake up late for school on the day of the exam.");
            Console.WriteLine("what do you do?");
            Console.WriteLine("1. Be honest with your teacher");
            Console.WriteLine("2. Tell the teacher you had a flat tire");
            Console.WriteLine("3. Go back to sleep");
            Console.Write("choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "Be honest with your teacher":
                case "tell him the truth":
                
                    {
                        Console.Clear();
                        Console.WriteLine("You explain to your teacher how you missed your alamr.");
                        Console.WriteLine("you remind him that this is your first time ever being late for an exam");
                        Console.WriteLine("Mr. Brooks your teacher is still upset but does take this into mind");
                        Console.WriteLine("He decideds to take the exam with points being taken off for being late");
                        Console.WriteLine("you pass despite having points taken off");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        youWin();
                        break;

                    }
                case "2":
                case "lie":
                    {
                        Console.WriteLine("You decide to lie and say you had a blow out on the side of the road");
                        Console.WriteLine("Mr. Brooks is not happy at all.");
                        Console.WriteLine("'This is the oldest excuse in the book, im giving you a 0 on your final exam.'");
                        Console.WriteLine("You sit in your car crying wishing you told the truth");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "3":
                case "sleep":
                case "go back to sleep":
                    {
                        Console.WriteLine("Despite knowing youre already late for class you decide to sleep in anyway");
                        Console.WriteLine("You were up too late drinking and knew you would fail anyway");
                        Console.ReadLine();
                        gameOver();
                        break;

                    }
            }
        }

        

        public static void gameOver()
        {
            
            Console.WriteLine("You find yourself working a deadend job still living at your parents house at the age of 40.");
            Console.WriteLine("Better luck next time.");
            Console.WriteLine("Press 'Enter' to try again");
            Console.WriteLine("Game Over");
            Console.ReadLine();
            Console.Clear();
            gameTitle();


        }

        public static void youWin()
        {
            
            Console.WriteLine("Your Honesty has rewarded you well!");
            Console.WriteLine("You find yourself living large in a penthouse with a net woth of $150,000,000.");
            Console.WriteLine("Thank you for playing.");
            Console.WriteLine("Press 'Enter to play again.");
            Console.Clear();
            gameTitle();
        }
    }
}
