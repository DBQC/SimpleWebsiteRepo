using CoreLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Implementation
{
    class WooWoo : IAnimal
    {
        private bool _domestic;
        private int _lifespan;

        public bool Domestic
        {
            get
            {
                return _domestic;
            }

            set
            {
                _domestic = value;
            }
        }
        public int Lifespan
        {
            get
            {
                return _lifespan;
            }

            set
            {
                _lifespan = value;
            }
        }

        public string Species
        {
            get { return "Canis lupis"; }
            set { }
        }
        public string PrintStats()
        {
            return $"Species:{Species}" + Environment.NewLine + $"Domesticated: {Domestic}" + Environment.NewLine + $"Average Lifespan: {Lifespan}";
        }
    }
}
