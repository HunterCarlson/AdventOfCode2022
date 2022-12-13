using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Day1
    {
        public static void Solve()
        {
            Console.WriteLine("Day 1: Calorie Counting");
            Console.WriteLine();

            Part1();
            Part2();
        }

        private static void Part1()
        {
            string inputFilePath = $"{Environment.CurrentDirectory}/Input/Day1Input.txt";
            string[] lines  = File.ReadAllLines(inputFilePath);

            int max = 0;
            int sum = 0;

            foreach (string line in lines)
            {
                int cal = 0;
                if (int.TryParse(line, out cal))
                {
                    sum += cal;
                }
                else
                {
                    if (sum > max)
                    {
                        max = sum;
                    }
                    sum = 0;
                }

            }

            Console.WriteLine(max);
        }

        private static void Part2()
        {
            string inputFilePath = $"{Environment.CurrentDirectory}/Input/Day1Input.txt";
            string[] lines = File.ReadAllLines(inputFilePath);

            List<int> cals = new List<int>();
            int sum = 0;

            foreach (string line in lines)
            {
                int cal = 0;
                if (int.TryParse(line, out cal))
                {
                    sum += cal;
                }
                else
                {
                    cals.Add(sum);
                    sum = 0;
                }
            }

            cals.Sort();
            cals.Reverse();
            int top3Sum = cals[0] + cals[1] + cals[2];
            Console.WriteLine(top3Sum);
        }
    }
}
