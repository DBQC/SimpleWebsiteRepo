using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Inheritance
{
    class WooWoo : Animal
    {
        private int _NumberOfLegs;

        public int NumberOfLegs
        {
            get { return _NumberOfLegs; }
        }

        public string Name { get; private set; }
        public TimeSpan Age { get; private set; }
        public DateTime Birthday { get; private set; }
        public WooWoo()
        {
            Name = "Good Boy";
            Species = "Doggo";
            Lifespan = 100;
            Domestic = true;
            Birthday = DateTime.Now;
            
        }
    }
}