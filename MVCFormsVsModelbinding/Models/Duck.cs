﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFormsVsModelbinding.Models
{
    /// <summary>
    /// Represents an individual Duck.
    /// </summary>
    public class Duck
    {
        /// <summary>
        /// The unique identifier for the Duck.
        /// </summary>
        public int DuckId { get; set; }

        /// <summary>
        /// The name of the Duck.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The color(s) of the Duck.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The Duck's favorite thing to say.
        /// </summary>
        public string CatchPhrase { get; set; }
    }
}
