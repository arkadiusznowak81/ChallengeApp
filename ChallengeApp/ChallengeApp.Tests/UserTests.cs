using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            //arrange
            var user1 = new User("Adam", "aaa");
            user1.AddScore(5); //5
            user1.AddScore(6); //11

            var user2 = new User("Anna", "bbb");
            user2.AddScore(-7); //-7
            user2.AddMinusScore(3); //-10
            user2.AddMinusScore(-8); //-18

            //act
            var result1 = user1.Result;
            var result2 = user2.Result;

            //assert
            Assert.AreEqual(11, result1);
            Assert.AreEqual(-18, result2);

        }
    }
}