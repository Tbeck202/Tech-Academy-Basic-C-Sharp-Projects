using System;
using System.Collections.Generic;


class Program
{
    
    static void Main(string[] args)
    {
        //EXERCISE 1-------------------------------------------------------------------------------------------
        //string[] greetings = { "hi ", "hello ", "what's up ", "what's good ", "hola ", "hey " };
        //Console.WriteLine("Please type your first name");
        //string name = Console.ReadLine();

        //for (int i = 0; i < greetings.Length; i++)
        //{
        //    Console.WriteLine(greetings[i] + name);
        //}
        //Console.ReadLine();

        // INFINITE LOOP -------------------------------------------------------------------

        //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

        //while (true)
        //{
        //    foreach (int number in numbers)
        //    {
        //        if (number <= numbers.Count)
        //        {
        //            Console.WriteLine(number + "00");

        //        }
        //    }
        //}
        //Console.ReadLine();


        //INFINTE LOOP FIXED---------------------------------------------------------------------------

        //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

        //    foreach (int number in numbers)
        //    {
        //        if (number <= numbers.Count)
        //        {
        //            Console.WriteLine(number + "00");
        //            continue;
        //        }
        //    }
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

        //List<string> players = new List<string>() { "donovan mitchell", "rudy gobert", "mike conley", "joe ingles", "bojan bogdanovich", "royce o'neale" };
        //Console.WriteLine("please enter your favorite jazz player's full name");
        //string favplayer = (Console.ReadLine());

        //foreach (string player in players)
        //{
        //    if (favplayer == player)
        //    {
        //        int index = players.FindIndex(a => a.Contains(favplayer));
        //        Console.WriteLine("your favorite player's full name is at index " + index);
        //    }
        //}
        //Console.ReadLine();

        // DISPLAY INDEX FROM SELECTED ITEM IN LIST WITH RULES-----------------------------------------------------------------------------------


        //Console.WriteLine("Please enter your favorite Jazz player's full name");
        //List<string> players = new List<string>() { "Donovan Mitchell", "Rudy Gobert", "Mike Conley", "Joe Ingles", "Bojan Bogdanovich", "Royce O'Neale" };
        //string favPlayer = (Console.ReadLine());
        //List<string> selection = players.FindAll(i => i.Equals(favPlayer));

        //foreach (string player in players)
        //{
        //    if (selection.Count > 0)
        //    {
        //        int index = players.FindIndex(a => a.Contains(favPlayer));
        //        Console.WriteLine("Your favorite player is at index " + index);
        //        break;
        //    }
        //    else 
        //    {
        //        Console.WriteLine("Player does not exist");
        //        break;
        //    }
        //}
        //Console.ReadLine();

        // DRILL 9 AND 10  ------------------------------------------------------------------------------------------------

        //List<string> colors = new List<string>() { "green", "red", "blue", "yellow", "orange", "blue", "purple" };
        //Console.WriteLine("Pick a color: red, green, blue, yellow, orange, purple. \nType your selection below.");
        //string colorPick = (Console.ReadLine());
        //List<string> selections = colors.FindAll(i => i.Equals(colorPick));

        //foreach (string color in colors)
        //{
        //    if (selections.Count > 1)
        //    {
        //        int index = colors.FindIndex(a => a.Contains(colorPick));
        //        int lastIndex = colors.FindLastIndex(a => a.Contains(colorPick));
        //        Console.WriteLine("Your color is at index " + index + " and index " + lastIndex);
        //        break;
        //    }
        //    else if (selections.Count == 1)
        //    {
        //        int index = colors.FindIndex(a => a.Contains(colorPick));
        //        Console.WriteLine("Your color is at index " + index);
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Your color does not exist");
        //        break;
        //    }
        //}
        //Console.ReadLine();

        // EXERCISE 11-------------------------------------------------------------------------------------------------------------

        //List<string> colors = new List<string>() { "green", "red", "blue", "yellow", "orange", "blue", "purple" };

        //foreach (string color in colors)
        //{
        //    if (colors.Contains(color))
        //    {
        //        List<string> colorFind = colors.FindAll(a => a.Equals(color));

        //        foreach (string find in colorFind)
        //        {
        //            if (colorFind.Count > 1)
        //            {
        //                int index = colors.FindIndex(i => i.Contains(color));
        //                Console.WriteLine("The color " + color + " exists twice in this list. (First appearing at index " + index + ")");
        //                break;
        //            }
        //            else if (colorFind.Count < 2)
        //            {
        //                Console.WriteLine(color);
        //            }
        //        }
        //    }
        //}

        //Console.ReadLine();

        //selections.Add(color);
        //if (selections.Contains(color))
        //{
        //    int index = colors.FindIndex(i => i.Contains(color));
        //    Console.WriteLine("This color exists twice in this list. First appearing at index " + index);
        //    continue;
        //}
        //else
        //{
        //    Console.WriteLine(color);
        //    continue;
        //}


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
        //    if (score > 85)
        //    {
        //        passingScores.Add(score);
        //    }
        //}
        //Console.WriteLine(passingScores.Count);
        //Console.ReadLine();
    }
}

