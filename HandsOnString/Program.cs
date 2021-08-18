using System;

namespace HandsOnString
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            String s1 = Console.ReadLine();
            Console.WriteLine(s.Length);
            Console.WriteLine(String.Compare(s1,s));
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s1.ToLower());
            Console.WriteLine(s.Contains("ab"));
            String[] words = { "abc", "def", "ghi", "jkl" };
            Console.WriteLine(String.Concat(words));
            char[] ch= s.ToCharArray();
            foreach(char c in ch)
                Console.WriteLine(c);
            Console.WriteLine(s.EndsWith("i"));
            Console.WriteLine(s.Equals("ghi"));
            Console.WriteLine(s.IndexOf('h'));
            Console.WriteLine(s.Insert(2,s1));
            Console.WriteLine(s.LastIndexOf('h'));
            Console.WriteLine(String.Join(",",words));
            Console.WriteLine(s.Substring(0, 3));

















        }
    }
}
