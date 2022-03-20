using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_Workshop.Models
{
    //"Application" is imp man :)
    public class HospitalContext: ApplicationDbContext
    {
        public DbSet<Patient> patient { get; set; }

       
                   

        public System.Data.Entity.DbSet<Mvc_Workshop.Models.Doctor> Doctors { get; set; }
    }
}