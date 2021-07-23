using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Your duck must have a name")]
        public string Name { get; set; }

        /// <summary>
        /// The color(s) of the Duck.
        /// </summary>
        [Display(Name = "Color")]
        [Required(ErrorMessage = "Your duck must have a color")]
        public string Color { get; set; }

        /// <summary>
        /// The Duck's favorite thing to say.
        /// </summary>
        [Display(Name = "Catchphrase")]
        [Required(ErrorMessage = "Your duck must have a catchphrase")]
        public string CatchPhrase { get; set; }
    }
}
