﻿namespace InterfaceTest.Entities
{
    internal class Vehicle
    {
        public string Model { get; protected set; }

        public Vehicle() { }
        public Vehicle(string model) { Model = model; }
    }
}
