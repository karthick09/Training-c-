using System;

namespace linq
{
    class test_scores
    {
        public static void display()
        {
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            orderby score descending
            select score;
            foreach (int testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }
        }
    }
    class test_mul_select
    {
        public static void display()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var pairs = from a in numbersA from b in numbersB where a < b select new { a, b };
            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
            }
        }
    }
    class test_orderby
    {
        public static void display()
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords = from w in words orderby w select w;
            Console.WriteLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
        }
    }
    class test_count
    {
        public static void display()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
        }
    }
}