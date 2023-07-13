using System;

namespace access
{
    class x
    {
        protected virtual void F()
        {
            Console.WriteLine("x.f");
        }
        protected virtual void F1()
        {
            Console.WriteLine("x.f1");
        }
    }

    class y : x
    {
        protected override void F()
        {
            Console.WriteLine("y.f");
        }
        protected override void F1()
        {
            Console.WriteLine("y.f1");
        }
        protected void dip()
        {
            base.F();
            base.F1();
        }
    }
    class test : y
    {
        public void display()
        {
            F();
            F1();
            dip();
        }
    }

}