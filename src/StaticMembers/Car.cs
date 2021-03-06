﻿using System;

namespace ProgrammingGuides.StaticMembers
{
    /// <summary>
    /// A <see cref="Car"/> contains two static members.
    /// These members are shared between all instances of <see cref="Car"/>.
    /// </summary>
    internal class Car
    {
        internal Car(string make, string model)
        {
            _make = make;
            _model = model;
        }

        internal void Print()
        {
            Console.WriteLine($"I am a {_make} {_model}.");
        }

        private static string _make;
        private static string _model;
    }
}