using System;

namespace CaseInsensitiveOs
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = string.Compare("º", "O", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine($"{result}");
        }
    }
}
