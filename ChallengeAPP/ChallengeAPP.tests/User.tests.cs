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
            user1.AddScore(-7);

            var result1 = user1.Result;

            Assert.AreEqual(4, result1);
        }
        [Test]
        public void CheckScoresSumOperation2()
        {
            var user2 = new User("Adam", "asdfgh");
            user2.AddScore(-2);
            user2.AddScore(6);
            user2.AddScore(-7);

            var result2 = user2.Result;

            Assert.AreEqual(-3, result2);
        }
    }
}