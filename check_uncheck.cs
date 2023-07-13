using System;

namespace check
{
    class test_check
    {
        public static void display()
        {
            int ten = 10;
            unchecked
            {
                int i1 = 2147483647 + ten;
                Console.WriteLine(i1);
            }
            checked
            {
                int i2 = 2147483647 + ten;
                Console.WriteLine(i2);
            }
        }
    }
}