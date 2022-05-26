using System;
using System.Text;
using System.Linq;

namespace _4_kata_Middle_Permutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "abc";
            string b = Kata.MiddlePermutation(a);
            Console.WriteLine(b);
        }
    }
    public class Kata
    {
        public static string MiddlePermutation(string s)
        {

            if (s.Length % 2 == 1)
            {
                char firstChar = s.OrderBy(x => x).ElementAt(s.Length / 2);
                return firstChar + MiddlePermutation(string.Concat(s.Where(x => x != firstChar)));
            }
            else
            {
                char firstChar = s.OrderByDescending(x => x).ElementAt(s.Length / 2);
                return firstChar + string.Concat(s.OrderByDescending(x => x).Where(x => x != firstChar));

            }

        }
    }
}
