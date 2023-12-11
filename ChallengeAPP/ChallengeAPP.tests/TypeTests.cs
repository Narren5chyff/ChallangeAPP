namespace ChallengeAPP.tests
{
    public class TypeTests
    {
        [Test]
        public void LoginValueCheck()
        {
            var user1 = GetUser("Adam", "asdfgh");
            var user2 = GetUser("Adam", "asdfgh");

            Assert.AreEqual(user1.Login, user2.Login);
        }
        [Test]
        public void DifferentUserCheck()
        {
            var user1 = GetUser("Adam", "asdfgh");
            var user2 = GetUser("Adam", "asdfgh");

            Assert.AreNotEqual(user1, user2);
        }
        [Test]
        public void AreTwoNumbersEqual()
        {
            int number1 = 135;
            int number2 = 135;

            Assert.AreEqual(number1, number2);
        }

        private User GetUser(string login, string password)
        {
            return new User(login, password);
        }
    }
}
