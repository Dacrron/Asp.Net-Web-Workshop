using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc_Workshop.Models
{
    public class Patient
    {

        public int id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Allergies")]
        public string allergies { get; set; }
        [Display(Name = "Temperature")]
        public int temp { get; set; }




    }
}