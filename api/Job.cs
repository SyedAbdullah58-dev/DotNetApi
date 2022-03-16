namespace api
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobType { get; set; }
        public DateTime PublishedDate { get; set; } = DateTime.Now;
        public IList<Applicant>? applicants { get; set; }
    }
}
