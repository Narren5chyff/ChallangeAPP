namespace ChallengeAPP
{ 
    public abstract class EmploeeBase : IEmploee
    {
        public EmploeeBase(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set;}
        public string Sex { get; private set;}

        public delegate void EmploeeGradeAdded(object sender, EventArgs args);

        public abstract event EmploeeGradeAdded GradeAdded;
        
        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatisticsInForEach();
    }
}
