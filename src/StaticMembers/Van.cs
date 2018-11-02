using System;

namespace ProgrammingGuides.StaticMembers
{
    /// <summary>
    /// A <see cref="Van"/> contains two readonly instance members.
    /// These members are exclusive to each instance of a <see cref="Van"/>.
    /// </summary>
    internal class Van
    {
        internal Van(string make, string model)
        {
            _make = make;
            _model = model;
        }

        internal void Print()
        {
            Console.WriteLine($"I am a {_make} {_model}.");
        }

        private readonly string _make;
        private readonly string _model;
    }
}