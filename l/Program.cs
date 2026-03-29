using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex1
            //List<int> numbers = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            //ListHelper.printlist("original",numbers);
            //ListHelper.printlistCount(numbers);
            //ListHelper.PrintFirstGrade(numbers);
            //ListHelper.PrintLastGrade(numbers);
            //ListHelper.GetFirstGradeAbove(90,numbers);
            //numbers.Sort();
            //ListHelper.printlist("After Sorting ", numbers);
            //var result = numbers.Where(n => n < 75).ToList();
            //ListHelper.printlist("Grades Below 75", result);
            //numbers.RemoveAll(n => n < 75);
            //ListHelper.printlist("After Removing Below 75", numbers);
            //bool has100 = numbers.Contains(100);
            //Console.WriteLine(has100);
            //List<string> strings = numbers.ConvertAll(n => $"Grade: {n}");
            //ListHelper.printlist( strings);
            #endregion


            #region Ex2
            SortedList<int, string> Leaderboard = new SortedList<int, string>()
            {
                [500] = "Ahmed",
                [200] = "Sara",
                [800] = "Ali",
                [350] = "Mona"
            };
            foreach (var i in Leaderboard)
            {
                Console.WriteLine($"{i.Key}:{i.Value}");
            }
            Console.WriteLine($"First key:{Leaderboard.Keys[0]}");
            Console.WriteLine($"First Value:{Leaderboard.Values[0]}");

            if (Leaderboard.ContainsKey(500))
                Console.WriteLine("It contains this number");
            else
                Console.WriteLine("It Doesnt Contain his number");

            if (Leaderboard.ContainsKey(999))
                Console.WriteLine(Leaderboard.Values[999]);
            else
                Console.WriteLine("There is no key with this number");

            Leaderboard.Remove(200);
            foreach (var i in Leaderboard)
            {
                Console.WriteLine($"{i.Key}:{i.Value}");
            }

            #endregion
        }
    }
}
