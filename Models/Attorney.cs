using System.Collections.Generic;

namespace site.Models
{
    public class Attorney
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string Title { get; set; }


        private ICollection<AttorneyAdmission> _admissions;
        public ICollection<AttorneyAdmission> Admissions
        {
            get { return _admissions ?? (_admissions = new HashSet<AttorneyAdmission>()); }
            set { _admissions = value; }
        }

        private ICollection<AttorneyEducation> _educations;
        public ICollection<AttorneyEducation> Educations
        {
            get { return _educations ?? (_educations = new HashSet<AttorneyEducation>()); }
            set { _educations = value; }
        }

        private ICollection<PracticeArea> _practiceAreas;
        public ICollection<PracticeArea> PracticeAreas
        {
            get { return _practiceAreas ?? (_practiceAreas = new HashSet<PracticeArea>()); }
            set { _practiceAreas = value; }
        }

        public Birthplace Birthplace { get; set; }
    }
}