using System;

namespace asyncExample
{
    class x
    {
        public static async Task DisplayCurrentInfoAsync()
        {
            await WaitAndApologizeAsync();
            Console.WriteLine($"Today is {DateTime.Now:D}");
            Console.WriteLine($"The current time is {DateTime.Now.TimeOfDay:t}");
            Console.WriteLine("The current temperature is 76 degrees.");
        }

        static async Task WaitAndApologizeAsync()
        {
            await Task.Delay(3000);
            Console.WriteLine("Sorry for the delay...\n");
        }
    }
}