using System;
using System.Collections.Generic;


class Program
{
    
    static void Main(string[] args)
    {
        //EXERCISE 1-------------------------------------------------------------------------------------------
        //    string[] greetings = { "hi ", "hello ", "what's up ", "what's good ", "hola ", "hey " };
        //    Console.WriteLine("Please type your first name");
        //    string name = Console.ReadLine();

        //    for (int i = 0; i < greetings.Length; i++)
        //    {
        //        Console.WriteLine(greetings[i] + name);
        //    }
        //    Console.ReadLine();

        // INFINITE LOOP -------------------------------------------------------------------

        //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

        //while(true)
        //{ 
        //    foreach (int number in numbers)
        //    {
        //        if (number > 0 )
        //        {
        //            Console.WriteLine(number + "00");
        //        }
        //    }
        //}

        //INFINTE LOOP FIXED---------------------------------------------------------------------------

        //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

        //foreach (int number in numbers)
        //{
        //    if (number > 0)
        //    {
        //        Console.WriteLine(number + "00");
        //    }
        //}
        //Console.ReadLine();

        // LOOP WITH A < OPERATOR -----------------------------------------------------------------------------------

        //string[] names = { "Donovan Mitchell", "Rudy Gobert", "Mike Conley", "Joe Ingles", "Bojan Bogdanovich", "Royce O'Neale" };

        //Console.WriteLine("The starting five for he Utah Jazz are:");
        //for (int i = 0; i < 5; i++)
        //{
        //    if (i <= 5)
        //    {
        //        Console.WriteLine(names[i]);
        //    }
        //}
        //Console.ReadLine();

        // LOOP WITH A <= OPERATOR -----------------------------------------------------------------------------------

        //string[] names = { "Donovan Mitchell", "Rudy Gobert", "Mike Conley", "Joe Ingles", "Bojan Bogdanovich", "Royce O'Neale" };

        //Console.WriteLine("The starting five plus sixth man for he Utah Jazz are:");
        //for (int i = 0; i <= 5; i++)
        //{
        //    if (i <= 5)
        //    {
        //        Console.WriteLine(names[i]);
        //    }
        //}
        //Console.ReadLine();

        // DISPLAY INDEX FROM SELECTED ITEM IN LIST -----------------------------------------------------------------------------------

        //List<string> players = new List<string>() { "Donovan Mitchell", "Rudy Gobert", "Mike Conley", "Joe Ingles", "Bojan Bogdanovich", "Royce O'Neale" };
        //Console.WriteLine("Please enter your favorite Jazz player's full name");
        //string favPlayer = (Console.ReadLine());

        //foreach (string player in players)
        //{
        //    if (favPlayer == player)
        //    {
        //        int index = players.FindIndex(a => a.Contains(favPlayer));
        //        Console.WriteLine("Your favorite player's full name is at index " + index);
        //    }
        //}
        //Console.ReadLine();

        // DISPLAY INDEX FROM SELECTED ITEM IN LIST WITH RULE ADDED-----------------------------------------------------------------------------------

        //List<string> players = new List<string>() { "Donovan Mitchell", "Rudy Gobert", "Mike Conley", "Joe Ingles", "Bojan Bogdanovich", "Royce O'Neale" };
        //Console.WriteLine("Please enter your favorite Jazz player's full name");
        //string favPlayer = (Console.ReadLine());

        //foreach (string player in players)
        //{
        //    if (favPlayer == player)
        //    {
        //        int index = players.FindIndex(a => a.Contains(favPlayer));
        //        Console.WriteLine("Your favorite player is at index " + index);
        //    }
        //    else 
        //    {
        //        Console.WriteLine("Player does not exist");
        //        break;
        //    }
        //}
        //Console.ReadLine();

        // DISPLAY INDEX FROM SELECTED ITEM IN LIST WITH RULE ADDED AND ENDING -----------------------------------------

        List<string> players = new List<string>() { "Donovan Mitchell", "Rudy Gobert", "Mike Conley", "Joe Ingles", "Bojan Bogdanovich", "Royce O'Neale" };
        //bool doesNotExist = true;
        Console.WriteLine("Please enter your favorite Jazz player's full name");
        string favPlayer = (Console.ReadLine());

        foreach (string player in players)
        {
            if (favPlayer == player)
            {
                int index = players.FindIndex(a => a.Contains(favPlayer));
                Console.WriteLine("Your favorite player is at index " + index);
                //doesNotExist = false;
            }
            else if (favPlayer != player)
            {
                Console.WriteLine("That  player does not exist. Try again.");
                Console.ReadLine();
            }
        }
        Console.ReadLine();


        //EXAMPLE 1-------------------------------------------------------------------------------------

        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //EXAMPLE 2A---------------------------------------------------------------------------------------------

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++ )
        //{
        //     if (names[j] == "Jesse")
        //    {
        //        Console.WriteLine(names[j]);
        //    }
        //}
        //Console.ReadLine();

        //EXAMPLE 2B---------------------------------------------------------------------------------------------------------

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++)
        //{ 
        //     Console.WriteLine(names[j]);  
        //}
        //Console.ReadLine();

        //EXAMPLE 3A------------------------------------------------------------------------------------------------------------

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}
        //Console.ReadLine();

        //EXAMPLE 3B------------------------------------------------------------------------------------------------------------

        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

        //foreach (string name in names)
        //{
        //    if (name == "Jesse")
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        //Console.ReadLine();

        //EXAMPLE 3C------------------------------------------------------------------------------------------------------------

        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

        //foreach (string name in names)
        //{
        //        Console.WriteLine(name);
        //}
        //Console.ReadLine();

        //EXAMPLE 4-----------------------------------------------------------------------------------------------------------

        //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        //List<int> passingScores = new List<int>();

        //foreach (int score in testScores)
        //{
        //    if (score > 85 )
        //    {
        //        passingScores.Add(score);
        //    }
        //}
        //Console.WriteLine(passingScores.Count);
        //Console.ReadLine();
    }
}

