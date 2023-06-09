namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Хранит значение оценки за семестр.
        /// </summary>
        private int _assessmentForTheSemester;

        /// <summary>
        /// Создает экземпляр класса Discipline.
        /// </summary>
        /// <param name="disciplinesName">Название дисциплины.</param>
        /// <param name="nameTeacher">Имя преподавателя.</param>
        /// <param name="assessmentForTheSemester">Оценка за семестр. Должна быть в диапазоне от 2 до 5.</param>
        public Discipline(string disciplinesName, string nameTeacher, int assessmentForTheSemester)
        {
            DisciplinesName = disciplinesName;
            NameTeacher = nameTeacher;
            AssessmentForTheSemester = assessmentForTheSemester;
        }

        /// <summary>
        /// Создает экземпляр класса Discipline.
        /// </summary>
        public Discipline() { }

        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        public string DisciplinesName { get; set; }

        /// <summary>
        /// Возвращает и задает имя преподавателя.
        /// </summary>
        public string NameTeacher { get; set; }

        /// <summary>
        /// Возвращает и задает оценку за семестр. Должна быть в диапазоне от 2 до 5.
        /// </summary>
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
