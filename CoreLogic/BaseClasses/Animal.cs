using CoreLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic
{
    /// <summary>
    /// Basic class to learn about inheritence.
    /// </summary>
    public abstract class Animal 
    {
        /// <summary>
        /// Name of the Species
        /// </summary>
        public string Species { get;  set; }
        /// <summary>
        /// Is the animal domesticated
        /// </summary>
        public bool Domestic { get;  set; }
        /// <summary>
        /// Average Lifespan for an indivdual animal.
        /// </summary>
        public int Lifespan { get;  set; }
        string PrintStats()
        {
            return $"Species:{Species}" + Environment.NewLine + $"Domesticated: {Domestic}" + Environment.NewLine + $"Average Lifespan: {Lifespan}";

        }
    }
}
