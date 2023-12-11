using System.ComponentModel;

namespace ChallengeAPP.tests
{
    public class Tests
    {
        [Test]
        public void CheckScoresSumOperation1()
        {
            var user1 = new User("Przemek", "asdfgh");
            user1.AddScore(5);
            user1.AddScore(6);
            user1.AddScore(7);

            var result1 = user1.Result;

            Assert.AreEqual(18, result1);
        }
        [Test]
        public void CheckScoresSumOperation2()
        {
            var user2 = new User("Adam", "asdfgh");
            user2.AddScore(-2);
            user2.AddScore(-6);
            user2.AddScore(-27);

            var result2 = user2.Result;

            Assert.AreEqual(-35, result2);
        }
        [Test]
        public void CheckScoresSumOperation3()
        {
            var user3 = new User("Kasia", "asdfgh");
            user3.AddScore(10);
            user3.AddScore(-6);
            user3.AddScore(8);

            var result3 = user3.Result;

            Assert.AreEqual(12, result3);
        }
    }
}