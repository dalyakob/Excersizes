namespace BONUS_1
{
    public class Grader
    {
        public Grader()
        {
        }
        public string GetGrades(double grade)
        {
            if(grade >= 88 && grade <= 100) { return "A"; }
            if(grade >= 80 && grade <= 87) { return "B"; }
            if(grade >= 67 && grade <= 79) { return "C"; }
            if(grade >= 60 && grade <= 66) { return "D"; }
            if(grade >= 0 && grade <= 60) { return "E"; }

            return null;
        }
    }
}