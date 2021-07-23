using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFormsVsModelbinding.Models
{
    public class Duck
    {
        public int DuckId { get; set; }

        /// <summary>
        /// The name of the duck.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The color(s) of the duck.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The duck's favorite thing to say.
        /// </summary>
        public string CatchPhrase { get; set; }
    }
}
