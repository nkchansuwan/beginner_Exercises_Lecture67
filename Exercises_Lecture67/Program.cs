using System;

namespace Exercises_Lecture67
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
        }

        public static void Exercise1()
        {
            Console.Write("Enter numbers separate by a hyphen : ");
            var stNumber = Console.ReadLine().Split('-');
            Array.Sort(stNumber);

            for (int i = 0; i < stNumber.Length; i++)
            {
                if (i != stNumber.Length - 1)
                {
                    if (Convert.ToInt32(stNumber[i + 1]) - Convert.ToInt32(stNumber[i]) != 1)
                    {
                        Console.WriteLine("Not Consective");
                        return;
                    }
                }
            }
            Console.WriteLine("Consective");
        }

        public static void Exercise2()
        {
            Console.Write("Enter numbers separate by a hyphen : ");

            var stNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(stNumber))
                return;

            var arrNumber = stNumber.Split('-');

            for (int i = 0; i < arrNumber.Length; i++)
            {
                for (int j = i + 1; j < arrNumber.Length; j++)
                {
                    if (arrNumber[i] == arrNumber[j])
                    {
                        Console.WriteLine("Duplicate");
                    }
                }
            }
        }

        public static void Exercise3()
        {
            Console.Write("Enter time value : ");
            var stTime = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(stTime))
                Console.WriteLine("Invalid Time");
            DateTime time = new DateTime();
            if (DateTime.TryParse(stTime, out time))
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Invalid Time");
        }

        public static void Exercise4()
        {
            Console.Write("Enter a few words separated by space :");
            var words = Console.ReadLine().Split(' ');

            if (words.Length == 0)
                return;

            var pascalCase = string.Empty;

            foreach (var item in words)
            {
                var wordU = item.ToUpper();
                var wordL = item.ToLower();

                pascalCase += wordL.Remove(0, 1).Insert(0, wordU.Substring(0, 1));
            }

            Console.WriteLine(pascalCase);
        }

        public static void Exercise5()
        {
            Console.Write("Enter English word : ");
            var word = Console.ReadLine();

            var chars = word.ToCharArray();
            var count = 0;
            foreach (var item in chars)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
