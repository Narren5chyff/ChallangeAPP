using System.ComponentModel;

namespace ChallengeAPP
{
    public class EmploeeInMemory : EmploeeBase
    {
        public override event EmploeeGradeAdded GradeAdded;

        private List<float> grades = new List<float>();

        public EmploeeInMemory(string name, string surname, string sex)
            : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception($"Value {grade} cannot be added");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))

                this.AddGrade(result);
            else

                switch (grade)
                {
                    case "A":
                    case "a":
                        this.AddGrade(100);
                        break;
                    case "B":
                    case "b":
                        this.AddGrade(80);
                        break;
                    case "C":
                    case "c":
                        this.AddGrade(60);
                        break;
                    case "D":
                    case "d":
                        this.AddGrade(40);
                        break;
                    case "E":
                    case "e":
                        this.AddGrade(20);
                        break;
                    default:
                        throw new Exception($"Invalid letter -{grade}-.");
                }
        }

        public override void AddGrade(long grade)
        {
            float valueInLong = (float)grade;
            this.AddGrade(valueInLong);
        }

        public override void AddGrade(double grade)
        {
            float valueInDouble = (float)grade;
            this.AddGrade(valueInDouble);
        }

        public override Statistics GetStatisticsInForEach()
        {
            var statistics = new Statistics();
            
            foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
