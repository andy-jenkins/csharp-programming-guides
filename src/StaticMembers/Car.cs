using System;

namespace ProgrammingGuides.StaticMembers
{
    public class Car
    {
        public Car(string make, string model)
        {
            _make = make;
            _model = model;
        }

        public void Print()
        {
            Console.WriteLine($"I am a {_make} {_model}.");
        }

        private static string _make;
        private static string _model;
    }
}