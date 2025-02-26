﻿using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler2();

            h1.SetSucessor(h2);
            h2.SetSucessor(h3);

            int[] requests = { 2, 5, 24, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandlerRequest(request);
            }
            Console.ReadKey();
        }
    }
}
