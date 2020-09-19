using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Net.Http.Headers;

namespace EnhancedPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            RelationalPatterns(12);

            // https://github.com/dotnet/roslyn/blob/master/docs/Language%20Feature%20Status.md

        }

        private static void RelationalPatterns(int months)
        {
            var stage = months switch
            {
                < 2 => "newborn",
                < 12 => "infant",
                <= 48 => "toddler",
                _ => "not defined"
            };
            Console.WriteLine(stage);
        }

        private static void SimplifiedTypePattern(object o)
        {
            if (o is string)
            {
                Console.WriteLine("it's a string");
            }

            string result = o switch
            {
                string => "it's a string",
                int => "it's an int",
                _ => "something else"
            };
            Console.WriteLine(result);
        }

        private static void LogicalPatterns(object? o)
        {
            if (o == null) throw new ArgumentNullException(nameof(o));
            if (o is null) throw new ArgumentNullException(nameof(o));
            if (o != null)
            {
                Console.WriteLine("not null");
            }
            if (!(o is null))
            {
                Console.WriteLine("not null");
            }
            if (o is not null)
            {
                Console.WriteLine("not null");
            }


        }
    }
}
