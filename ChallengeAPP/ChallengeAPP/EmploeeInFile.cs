namespace ChallengeAPP
{
    public class EmploeeInFile : EmploeeBase
    {
        private const string fileName = "grades.txt";

        public override event EmploeeGradeAdded GradeAdded;
        public EmploeeInFile (string name, string surname, string sex)
            : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
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
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
