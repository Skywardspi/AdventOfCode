
using AdventOfCode_Day_1;
using System.Text;

class Day1
{
    public static void Main()
    {
        string path = @"E:\Programming\AdventOfCode\AdventOfCode\AdventOfCode Day 1\adventofcode.com_2022_day_1_input.txt";
        bool valid = false;

        while (!valid)
        {
            Console.WriteLine("Do you choose to see the result of Part 1 or 2?");
            
            string part = Console.ReadLine();

            List<string> lines = File.ReadLines(path).ToList();

            switch (part)
            {
                case "1":
                    valid = true; 
                    Part1(lines); 
                    break;

                case "2":
                    valid = true;
                    Part2(lines);
                    break;

                default: Console.WriteLine("Invalid option chosen! Valid options are 1 and 2!"); break;
            }

        }

    }

    public static void Part1(List<string> lines)
    {
        int highestValue = 0;

        int tempSum = 0;

        foreach (string line in lines)
        {
            if (String.IsNullOrWhiteSpace(line))
            {
                if (tempSum > highestValue)
                {
                    highestValue = tempSum;
                }

                Console.WriteLine(tempSum);

                tempSum = 0;
            }
            else
            {

                tempSum += Int32.Parse(line);
            }
        }

        Console.WriteLine("The highest value is: " + highestValue);
    }

    public static void Part2(List<string> lines)
    {
        List<int> highestValues = new List<int>() { 0, 0, 0 };
        int totalValue = 0;
        int tempSum = 0;

        foreach (string line in lines)
        {
            if (String.IsNullOrWhiteSpace(line))
            {
                if (tempSum > highestValues[0])
                {
                    highestValues[0] = tempSum;
                }
                else if (tempSum > highestValues[1])
                {
                    highestValues[1] = tempSum;
                }
                else if (tempSum > highestValues[2])
                {
                    highestValues[2] = tempSum;
                }

                Console.WriteLine(tempSum);

                tempSum = 0;
            }
            else
            {
                tempSum += Int32.Parse(line);
            }
        }

        totalValue = highestValues[0] + highestValues[1] + highestValues[2];

        Console.WriteLine("The 3 highest values are: {0}, {1} and {2}\nAnd their combined value is: {3}", highestValues[0], highestValues[1], highestValues[2], totalValue );
    }

}
