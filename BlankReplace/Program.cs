using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What string are you starting with?");
            var startString = Console.ReadLine();
            Console.WriteLine("What do you want to replace in that string?");
            var stringToReplace = Console.ReadLine();
            Console.WriteLine("What do you want to replace it with?");
            var replaceString = Console.ReadLine();
            Console.WriteLine("Your new string is:");
            Console.WriteLine(ReplacedString(startString, stringToReplace, replaceString));
            Console.ReadLine();

        }

        public static string ReplacedString(string startString, string stringToReplace, string replaceString)
        {
            return startString.Replace(stringToReplace, replaceString);
        }
    }
}
