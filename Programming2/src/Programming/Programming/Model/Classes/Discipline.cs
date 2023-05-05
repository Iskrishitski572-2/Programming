namespace Programming.Model.Classes
{
    public class Discipline
    {
        private int _semesterNumber;
        private int _semesterGrade;

        public Discipline(string nameDiscipline, string nameTeacher, int semesterNumber, int semesterGrade)
        {
            NameDiscipline = nameDiscipline;
            NameTeacher = nameTeacher;
            SemesterNumber = semesterNumber;
            SemesterGrade = semesterGrade;
        }

        public Discipline() { }
    
        public string NameDiscipline { get; set; }

        public string NameTeacher { get; set; }

        public int SemesterNumber
        {
            get => _semesterNumber;
            set
            {
                Validator.AssertValueInRange(value, nameof(SemesterNumber), 1, 8);
                _semesterNumber = value;
            }
        }

        public int SemesterGrade
        {
            get => _semesterGrade;
            set
            {
                Validator.AssertValueInRange(value, nameof(SemesterGrade), 2, 5);
                _semesterGrade = value;
            }
        }
    }
}