using System.Data;
using System.Runtime.CompilerServices;
using System.Collections;
using System;
using System.Runtime.Serialization;

namespace rec
{
    public record Person(string FirstName, string LastName, string[] PhoneNumbers);

    class test_person
    {
        public static void display()
        {
            var phoneNumbers = new string[2];
            Person person1 = new("Nancy", "Davolio", phoneNumbers);
            Person person2 = new("Nancy", "Davolio", phoneNumbers);
            Console.WriteLine(person1 == person2);
            person1.PhoneNumbers[0] = "555-1234";
            Console.WriteLine(person1 == person2);
            Console.WriteLine(person1 + " next\n" + person2);
            Console.WriteLine(ReferenceEquals(person1, person2));
        }
    }

}