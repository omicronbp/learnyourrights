using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace site.Models
{
    public class LearnYourRightsDb : DbContext
    {
        public DbSet<SiteProperty> SiteProperties { get; set; }

        public DbSet<Attorney> Attorneys { get; set; }

        public DbSet<Admission> Admissions { get; set; }

        public DbSet<AttorneyAdmission> AttorneyAdmissions { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<AttorneyEducation> AttorneyEducations { get; set; }

        public DbSet<Birthplace> Birthplaces { get; set; }

        public DbSet<PracticeArea> PracticeAreas { get; set; }
    }
}