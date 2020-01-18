using System;

namespace NumberGuessingGame
{
    class Program
    {
         
            class Game
            {
            private int GeneratedNum; //Private variable for generated number
            private int NumGuess; //Private variable for User's guess


            public Game() //public class for generating random number
            {
                Random rnd = new Random(); //initiate random object
                this.GeneratedNum = rnd.Next(1, 100); //generate random number between 1 and 100
                this.NumGuess = 0; //Number of guesses variable
            }

            public string turn(Double UserGuess) //Public function turn, takes UserGuess as input
            {
                this.NumGuess++; //Iterate NumGuess

                if (UserGuess > this.GeneratedNum) //if NumGuess is greater than generated number
                {
                    return "Your guess is too HIGH!"; //Print too high message
                }
                else if (UserGuess < this.GeneratedNum) //if NumGuess is less than generated number
                {
                    return "Your guess is too LOW!"; //print guess is too low
                }
                else if (UserGuess == this.GeneratedNum) //if it's equal to generated number
                {
                    return "Correct! You took " + this.NumGuess + " guesses to find the number!"; //return number of guesses taken
                }

                return ""; //return nothing from class except in IF statements
            }
        }

        static void Main(string[] args) //main method
        {

            Game game = new Game(); //create game object

            Console.WriteLine("A number between 1 and 100 has been generated. Please guess the number!"); //Help text/Instructions

            while (true) //Indefinetly
            {
                try
                {
                    Double UserGuess = Convert.ToDouble(Console.ReadLine()); //Take user guess input
                    string message = game.turn(UserGuess); //parse UserGuess into Game object
                    Console.WriteLine(message); //Write message
                }
                catch
                {
                    Console.WriteLine("Something went wrong"); //Write error message

                }
            }
        }
    } }
