namespace Challenge06
{
    [Serializable]
    public class ExamGrade
    {
        public int Grade { get; set; }
        public Lesson Lesson { get; set; }

        public ExamGrade(Lesson lesson, int grade)
        {
            Lesson = lesson;
            Grade = grade;
        }
        public ExamGrade()
        {

        }
    }
}