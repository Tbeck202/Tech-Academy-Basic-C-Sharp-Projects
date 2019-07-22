using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] nameArray = { "Donovan Mitchell", "Rudy Gobert", "Joe Ingles" };
        Console.WriteLine("Type 0, 1, or 2 to pick a new favorite basketball player.");
        int selection = Convert.ToInt32(Console.ReadLine());

        bool isSelected = selection < nameArray.Length;

        do
        {
            if (isSelected)
            {
                Console.WriteLine("Your new favorite basketball player is:");
                Console.WriteLine(nameArray[selection]);
                Console.WriteLine("Press enter to continue");
                break;
            }
            else
            {
                Console.WriteLine("You broke the rules! Please select 0, 1 , or 2");
                int newSelection = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your new favorite basketball player is:");
                Console.WriteLine(nameArray[newSelection]);
                Console.WriteLine("Press enter to continue");
                break;
            }
        }
        while (!isSelected);
        Console.ReadLine();

        int[] intArray = { 45, 27, 2 };
        Console.WriteLine("Type the same number from before to see \nyour new favorite basketball players jersey number.");
        int numSelection = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your new favorite basketball players jersey number is:");
        Console.WriteLine(intArray[numSelection]);
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();

        List<string> stringList = new List<string>();
        stringList.Add("red");
        stringList.Add("blue");
        stringList.Add("green");
        stringList.Add("purple");
        stringList.Add("yellow");
        stringList.Add("black");

        Console.WriteLine("Type any number from 0 to 5 to pick a color");
        int colorChoice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("You have chosen " + stringList[colorChoice] + "!");
        Console.ReadLine();


        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);

        //List<string> stringlist = new List<string>();
        //stringlist.Add("Hello");
        //stringlist.Add("Tyler");

        //Console.WriteLine(stringlist[0]);
        //Console.ReadLine();

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
}

