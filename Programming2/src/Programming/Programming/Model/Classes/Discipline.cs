namespace Programming.Model
{
    public class Discipline
    {
        private int _assessmentForTheSemester;

        public Discipline(string disciplinesName, string nameTeacher, int assessmentForTheSemester)
        {
            DisciplinesName = disciplinesName;
            NameTeacher = nameTeacher;
            AssessmentForTheSemester = assessmentForTheSemester;
        }

        public Discipline() { }

        public string DisciplinesName { get; set; }
        public string NameTeacher { get; set; }

        public int AssessmentForTheSemester
        {
            get { return _assessmentForTheSemester; }

            set
            {
                Validator.AssertValueInRange(value, nameof(AssessmentForTheSemester), 2, 5);

                _assessmentForTheSemester = value;

            }
        }

    }
}
