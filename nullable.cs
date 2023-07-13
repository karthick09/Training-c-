using System;


namespace nullable
{
    class test_null
    {
        public static void display()
        {
            int? a = null;
            int i = 10;
            i = a ?? 0;
            Console.WriteLine("a=" + a + "i=" + i);
        }
    }
}