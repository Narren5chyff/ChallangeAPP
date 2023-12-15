namespace ChallengeAPP.tests
{
    public class EmploeeTests
    {
        [Test]
        public void NewEmploee()
        {
            var emploee1 = GetEmploee("Jan", "Kowalski");
            var emploee2 = GetEmploee("Jan", "Kowalski");

            Assert.AreNotEqual(emploee1, emploee2);
        }
        [Test]
        public void HighestGrade()
        {
            var emploee1 = new Emploee("Jan", "Kowalski");
            emploee1.AddGrade(2);
            emploee1.AddGrade(7);
            emploee1.AddGrade(9);

            var statistics = emploee1.GetStatisticsInForEach();

            Assert.AreEqual(9, statistics.Max);
        }
        [Test]
        public void LowestGrade()
        {
            var emploee1 = new Emploee("Jan", "Kowalski");
            emploee1.AddGrade(1.5F);
            emploee1.AddGrade(5);
            emploee1.AddGrade(7);

            var statistics = emploee1.GetStatisticsInForEach();

            Assert.AreEqual(1.5, statistics.Min);
        }
        [Test]
        public void AverageGrade()
        {
            var emploee1 = new Emploee("Jan", "Kowalski");
            emploee1.AddGrade(2.5F);
            emploee1.AddGrade(6);
            emploee1.AddGrade(9.5F);

            var statistics = emploee1.GetStatisticsInForEach();

            Assert.AreEqual(6, statistics.Average);
        }
        [Test]
        public void DoubleEqualsFloat()
        {
            double valueInDouble = 20;
            float value = 20;

            Assert.AreEqual(valueInDouble, value);
        }
        [Test]
        public void LetterValue()
        {
            var emploee1 = new Emploee("Jan", "Kowalski");
            emploee1.AddGrade("A");
            emploee1.AddGrade(90);

            var statistics = emploee1.GetStatisticsInForEach();

            Assert.AreEqual('A', statistics.AverageLetter);
        }
        [Test]
        public void AddingLetters()
        {
            var emploee1 = new Emploee("Jan", "Kowalski");
            emploee1.AddGrade("A");
            emploee1.AddGrade(90);

            var statistics = emploee1.GetStatisticsInForEach();

            Assert.AreEqual('A', statistics.AverageLetter);
        }
        private Emploee GetEmploee(string name, string surname)
        {
            return new Emploee(name, surname);
        }
    }
}
