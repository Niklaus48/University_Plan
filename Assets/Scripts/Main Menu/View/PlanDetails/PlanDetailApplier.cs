using Domain.Entities;
using TMPro;
using UnityEngine;

namespace Main_Menu.View.PlanDetails
{
    public class PlanDetailApplier : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI courseId;
        [SerializeField] private TextMeshProUGUI courseName;
        [SerializeField] private TextMeshProUGUI group;
        [SerializeField] private TextMeshProUGUI professorId;
        [SerializeField] private TextMeshProUGUI professorName;
        [SerializeField] private TextMeshProUGUI universityId;
        [SerializeField] private TextMeshProUGUI universityName;
        [SerializeField] private TextMeshProUGUI dayOfWeek;
        [SerializeField] private TextMeshProUGUI date;
        [SerializeField] private TextMeshProUGUI time;
        [SerializeField] private TextMeshProUGUI majorId;
        [SerializeField] private TextMeshProUGUI majorName;
        [SerializeField] private TextMeshProUGUI status;
        

        public void Init(Plan plan)
        {
            courseId.text = plan.CourseId;
            courseName.text = plan.CourseName;
            group.text = plan.Group;
            professorId.text = plan.ProfessorId;
            professorName.text = plan.ProfessorName;
            universityId.text = plan.UniversityId;
            universityName.text = plan.UniversityName;
            dayOfWeek.text = plan.DayOfWeek;
            date.text = plan.Date;
            time.text = plan.Time;
            majorId.text = plan.MajorId;
            majorName.text = plan.MajorName;
            status.text = plan.Status;
        }
    }
}