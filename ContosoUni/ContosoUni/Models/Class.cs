namespace ContosoUni.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string LastNme { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
