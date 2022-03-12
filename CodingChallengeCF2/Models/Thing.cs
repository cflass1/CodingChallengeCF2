using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodingChallengeCF2.Models
{
    public class Thing
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Planet")]
        public string Planet { get; set; }
        [Display(Name = "Hazard")]
        public string Hazard { get; set; }

    }
}