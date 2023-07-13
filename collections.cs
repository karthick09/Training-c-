using System.Collections;
using System;

namespace collections
{
    class test_collections
    {
        public static void display()
        {
            int[] a = new[] { 0, 1, 2, 3, 4, 5, 6, 78, 9 };
            int lst = a[5];
            Console.WriteLine("last element" + lst);
            Console.WriteLine(sizeof(long));
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13, 14, 15));
            Console.WriteLine(numbers.Rest.Item1.Item4);
            var arrlist = new ArrayList();
            var arrlist2 = new ArrayList();
            arrlist.Add(12);
            arrlist.Add(1111);
            string[] arr = new string[] { "karthick", "raghul", "srf" };
            var arrlist1 = new ArrayList();
            arrlist1.Add(arrlist);
            arrlist1.Add(arr);
            arrlist2.Add(arr);
            arrlist2.AddRange(arrlist1);
            var list = new ArrayList();
            foreach (var item in arrlist1)
            {
                if (item is ArrayList)
                {
                    list = (ArrayList)item;
                }
            }
            arrlist.Add(159);
            foreach (var item in list)
            {
                Console.WriteLine("arrlist in arrlist 1using add" + item);
            }
            foreach (var item in arrlist2)
            {
                Console.WriteLine("arrlist 2 element using addrange" + item);
            }
            foreach (var item in arrlist1)
            {
                Console.WriteLine("items in arrlist1 uisng add" + item);
            }
        }
    }
}