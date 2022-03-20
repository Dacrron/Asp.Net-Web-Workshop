using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc_Workshop.Models
{
    public class Doctor
    {
        public int id { get; set; }
        [Display(Name = "Doctor Name")]
        
        public string name { get; set; }
        [Display(Name = "Speciality")]
        public string speciality { get; set; }



    }
}