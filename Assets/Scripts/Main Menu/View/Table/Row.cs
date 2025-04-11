using Domain.Entities;
using TMPro;
using UnityEngine;

namespace Main_Menu.View.Table
{
    public class Row : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI courseId;
        [SerializeField] private TextMeshProUGUI courseName;
        [SerializeField] private TextMeshProUGUI group;
        [SerializeField] private TextMeshProUGUI professorName;
        [SerializeField] private TextMeshProUGUI universityName;
        [SerializeField] private TextMeshProUGUI dayOfWeek;
        [SerializeField] private TextMeshProUGUI date;
        [SerializeField] private TextMeshProUGUI time;
        [SerializeField] private TextMeshProUGUI majorName;
        [SerializeField] private TextMeshProUGUI status;
        
        private int id;

        public void Init(Plan plan)
        {
            gameObject.SetActive(true);
            id = plan.Id;
            courseId.text = plan.CourseId;
            courseName.text = plan.CourseName;
            group.text = plan.Group;
            professorName.text = plan.ProfessorName;
            universityName.text = plan.UniversityName;
            dayOfWeek.text = plan.DayOfWeek;
            date.text = plan.Date;
            time.text = plan.Time;
            majorName.text = plan.MajorName;
            status.text = plan.Status;
        }
    }
}