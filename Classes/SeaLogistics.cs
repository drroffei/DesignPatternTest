using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dp_test.Interfaces;

namespace dp_test.Classes
{
    public class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}