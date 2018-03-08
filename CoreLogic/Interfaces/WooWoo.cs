using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Interfaces
{
    class WooWoo : Animal
    {
        public string Name { get; private set; }
        public TimeSpan Age { get; private set; }
        public DateTime Birthday { get; private set; }
        public WooWoo()
        {
            Name = "Good Boy";
            Species = "Dog";
            Lifespan = 14;
            Domestic = true;
            Birthday = DateTime.Now;
            
        }
    }
}