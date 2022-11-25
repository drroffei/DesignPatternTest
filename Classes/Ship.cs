using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dp_test.Interfaces;

namespace dp_test.Classes
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("TOOT TOOT! Package delivered by ship.");
        }
    }
}