namespace site.Models
{
    public class AttorneyAdmission
    {
        public int Id { get; set; }
        public Admission Admission { get; set; }
        public int Year { get; set; }
        //public int AttorneyId { get; set; }
    }
}