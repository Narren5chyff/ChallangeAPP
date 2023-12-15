namespace ChallengeAPP
{
    public class Emploee
    {
        private List<float> grades = new List<float>();

        public Emploee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"Value {grade} cannot be added");
            }
        }
        public void AddGrade(string grade)
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
                        Console.WriteLine($"Invalid letter -{grade}-.");
                        break;
                }
        }
        public void AddGrade(long grade)
        {
            float valueInLong = (float)grade;
            this.AddGrade(valueInLong);
        }
        public void AddGrade(double grade)
        {
            float valueInDouble = (float)grade;
            this.AddGrade(valueInDouble);
        }
        public Statistics GetStatisticsInForEach()
        {
            var statistics1 = new Statistics();
            statistics1.Min = float.MaxValue;
            statistics1.Max = float.MinValue;
            statistics1.Average = 0;

            foreach (var grade in this.grades)
            {
                statistics1.Min = Math.Min(statistics1.Min, grade);
                statistics1.Max = Math.Max(statistics1.Max, grade);
                statistics1.Average += grade;
            }
            statistics1.Average /= this.grades.Count;

            switch (statistics1.Average)
            {
                case var average when average >= 80:
                    statistics1.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics1.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics1.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics1.AverageLetter = 'D';
                    break;
                default:
                    statistics1.AverageLetter = 'E';
                    break;
            }

            return statistics1;
        }
    }
}
