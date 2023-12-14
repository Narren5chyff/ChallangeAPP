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
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine($"String value -{grade}- cannot be changed to float value");
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

            return statistics1;
        }
        public Statistics GetStatisticsInFor()
        {
            var statistics2 = new Statistics();
            statistics2.Min = float.MaxValue;
            statistics2.Max = float.MinValue;
            statistics2.Average = 0;

            for (var index = 0; index < this.grades.Count; index++)
            {
                statistics2.Min = Math.Min(statistics2.Min, this.grades[index]);
                statistics2.Max = Math.Max(statistics2.Max, this.grades[index]);
                statistics2.Average += this.grades[index];
            }
            statistics2.Average /= this.grades.Count;

            return statistics2;
        }
        public Statistics GetStatisticsInDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Min = float.MaxValue;
            statistics3.Max = float.MinValue;
            statistics3.Average = 0;

            var index = 0;

            do
            {
                statistics3.Min = Math.Min(statistics3.Min, this.grades[index]);
                statistics3.Max = Math.Max(statistics3.Max, this.grades[index]);
                statistics3.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);

            statistics3.Average /= this.grades.Count;

            return statistics3;
        }
        public Statistics GetStatisticsInWhile()
        {
            var statistics4 = new Statistics();
            statistics4.Min = float.MaxValue;
            statistics4.Max = float.MinValue;
            statistics4.Average = 0;

            var index = 0;

            while (index < this.grades.Count)
            {
                statistics4.Min = Math.Min(statistics4.Min, this.grades[index]);
                statistics4.Max = Math.Max(statistics4.Max, this.grades[index]);
                statistics4.Average += this.grades[index];
                index++;
            }

            statistics4.Average /= this.grades.Count;

            return statistics4;
        }
    }
}
