using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CalorieCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            List<int> calories = new List<int>();
            int caloriesValue = 0;
            for(int i=0; i < lines.Length; i++)
            {
                if (int.TryParse(lines[i]?.Trim(), out var calorie))
                {
                    caloriesValue += calorie;
                }
                if (string.IsNullOrEmpty(lines[i]))
                {
                    calories.Add(caloriesValue);
                    caloriesValue = 0;
                }
            }
            Console.WriteLine("Total highest calories of Elf carring is: " + findHighCaloriesValue(calories));
            Console.WriteLine("Three highest calories of Elf carring is: " + findThreeHighCaloriesValues(calories));
            Console.ReadKey();
        }
        static int findHighCaloriesValue(List<int> calories)
        {
            int max = 0;
            for(int i = 0; i < calories.Count; i++)
            {
                if(max < calories[i])
                {
                    max = calories[i];
                }
            }
            return max;
        }
        static int findThreeHighCaloriesValues(List<int> calories)
        {
            calories.Sort();
            calories.Reverse();
            int countCalories = 0;

            for(int i=0; i < 3; i++)
            {
                countCalories += calories[i];            
            }
            return countCalories;
        }
    }
}
