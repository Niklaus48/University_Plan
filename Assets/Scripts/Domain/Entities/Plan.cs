namespace Domain.Entities
{
    public class Plan
    {
        public int Id { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string Group { get; set; }
        public string ProfessorId { get; set; }
        public string ProfessorName { get; set; }
        public string UniversityId { get; set; }
        public string UniversityName { get; set; }
        public string DayOfWeek { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string MajorId { get; set; }
        public string MajorName { get; set; }
        public string Status { get; set; }
    }
}