namespace site.Models
{
    public class AttorneyEducation
    {
        public int Id { get; set; }
        public Education Education { get; set; }
        public int Year { get; set; }
        public string Degree { get; set; }
        //public int AttorneyId { get; set; }
    }
}