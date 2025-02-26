﻿using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();

            originator.State = "On";

            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();


            originator.State = "Off";
            originator.SetMemento(caretaker.Memento);

            Console.ReadKey();
        }
    }
}
