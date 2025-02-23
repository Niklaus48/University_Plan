using System.Collections.Generic;

namespace Main
{
    public class PlanFilter
    {
        public readonly List<string> CourseName = new List<string>();
        public readonly List<string> Group = new List<string>();
        public readonly List<string> ProfessorName = new List<string>();
        public readonly List<string> UniversityName = new List<string>();
        public readonly List<string> DayOfWeek = new List<string>();
        public readonly string StartDate;
        public readonly string EndDate;
        public readonly List<string> Time = new List<string>();
        public readonly List<string> MajorName = new List<string>();
        public readonly string Status;
    }
}