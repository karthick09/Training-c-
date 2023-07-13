using System;
using System.Text;

namespace stringBuilder
{
    class builder
    {
        public static void display()
        {
            StringBuilder sb = new StringBuilder("ABC", 50);
            sb.Append(new char[] { 'D', 'E', 'F' });
            sb.AppendFormat("GHI{0}{1}", 'J', 'k');
            Console.WriteLine("{0} chars are - {1}", sb.Length, sb.ToString());
            sb.Insert(0, "Alphabet: ");
            sb.Replace('k', 'K');
            Console.WriteLine("{0} chars are - {1}", sb.Length, sb.ToString());
        }
    }
}