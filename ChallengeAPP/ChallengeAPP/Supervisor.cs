namespace ChallengeAPP
{
    public class Supervisor : IEmploee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception($"Value {grade} cannot be added");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))

                this.AddGrade(result);
            else

                switch (grade)
                {
                    case "Ocena: 6":
                        this.AddGrade(100);
                        break;
                    case "Ocena: 6-":
                    case "Ocena: -6":
                        this.AddGrade(95);
                        break;
                    case "Ocena: 5+":
                    case "Ocena: +5":
                        this.AddGrade(85);
                        break;
                    case "Ocena: 5":
                        this.AddGrade(80);
                        break;
                    case "Ocena: 5-":
                    case "Ocena: -5":
                        this.AddGrade(75);
                        break;
                    case "Ocena: 4+":
                    case "Ocena: +4":
                        this.AddGrade(65);
                        break;
                    case "Ocena: 4":
                        this.AddGrade(60);
                        break;
                    case "Ocena: 4-":
                    case "Ocena: -4":
                        this.AddGrade(55);
                        break;
                    case "Ocena: 3+":
                    case "Ocena: +3":
                        this.AddGrade(45);
                        break;
                    case "Ocena: 3":
                        this.AddGrade(40);
                        break;
                    case "Ocena: 3-":
                    case "Ocena: -3":
                        this.AddGrade(35);
                        break;
                    case "Ocena: 2+":
                    case "Ocena: +2":
                        this.AddGrade(25);
                        break;
                    case "Ocena: 2":
                        this.AddGrade(20);
                        break;
                    case "Ocena: 2-":
                    case "Ocena: -2":
                        this.AddGrade(15);
                        break;
                    case "Ocena: 1+":
                    case "Ocena: +1":
                        this.AddGrade(5);
                        break;
                    case "Ocena: 1":
                        this.AddGrade(0);
                        break;
                    default:
                        throw new Exception($"Invalid rate -{grade}-.");
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
            var statistics = new Statistics();
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;

            foreach (var grade in this.grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
