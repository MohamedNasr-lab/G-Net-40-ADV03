using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace l
{
    public class ListHelper
    {
        public static void printlist<T>(string s,List<T>numbers)
        {
            Console.WriteLine($"{s } : {string.Join(", ", numbers)}");
        }
        public static void printlistCount<T>(List<T> numbers)
        {
            Console.WriteLine($"List Count:{numbers.Count()}");
        }
        public static void PrintFirstGrade<T>(List<T> numbers)
        {
            Console.WriteLine($"First Grade is:{numbers[0]}");
        }
        public static void PrintLastGrade<T>(List<T> numbers)
        {
            Console.WriteLine($"Last Grade: {numbers[numbers.Count - 1]}");
        }
        public static void GetFirstGradeAbove(int num, List<int> numbers)
        {
            int first = numbers.Find(n => n > num);
            Console.WriteLine($"First Grade Above {num} is {first}");
        }
        public static void printlist<T>( List<T> numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
