using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Interfaces
{
    /// <summary>
    /// Basic Interface to learn about Implementing.
    /// </summary>
    interface IAnimal
    {
        /// <summary>
        /// Name of the Species
        /// </summary>
        string Species { get;  set; }
        /// <summary>
        /// Is the animal domesticated
        /// </summary>
        bool Domestic { get;  set; }
        /// <summary>
        /// Average Lifespan for an indivdual animal.
        /// </summary>
        int Lifespan { get;  set; }

        string PrintStats(); 
    }
}
