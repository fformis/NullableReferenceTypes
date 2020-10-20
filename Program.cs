using System;
using System.ComponentModel.DataAnnotations;

namespace NullableReferenceTypes
{
    #nullable enable
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person(null!);
        }

        class Person { 
            public Person(string firstName) => FirstName = firstName??throw new ArgumentNullException(nameof(firstName));
            public string FirstName { get; } 
        }
    }
}
