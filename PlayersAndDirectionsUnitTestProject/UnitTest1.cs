using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayersAndDirections;

namespace PlayersAndDirectionsUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlayerTestMethod1()
        {
            Player pl1 = new Player(1, "iskormovaca", 5, 4, 500);

            Assert.AreEqual("iskormovaca", pl1.getUsername());
        }
        [TestMethod]
        public void PlayerTestMethod2()
        {
            Player pl1 = new Player(1, "iskormovaca", 5, 4, 500);
            pl1.setUsername("me4o");

            Assert.AreEqual("me4o", pl1.getUsername());
        }

        [TestMethod]
        public void PlayerTestMethod3()
        {
            Player pl1 = new Player(1, "iskormovaca", 5, 4, 500);

            Assert.AreEqual(1, pl1.getId());
        }

        [TestMethod]
        public void PlayerTestMethod4()
        {
            Player pl1 = new Player(1, "iskormovaca", 5, 4, 500);
            pl1.setId(4);

            Assert.AreEqual(4, pl1.getId());
        }

        [TestMethod]
        public void PlayerTestMethod5()
        {
            Player pl1 = new Player(1, "iskormovaca", 5, 4, 500);


            Assert.AreEqual(5, pl1.getxPos());
            Assert.AreEqual(4, pl1.getyPos());
        }

        [TestMethod]
        public void PlayerTestMethod6()
        {
            Player pl1 = new Player(1, "iskormovaca", 5, 4, 500);

            pl1.setxPos(1);
            pl1.setyPos(-3);

            Assert.AreEqual(1, pl1.getxPos());
            Assert.AreEqual(-3, pl1.getyPos());
        }

        [TestMethod]
        public void PlayerTestMethod7()
        {
            Player pl1 = new Player(1, "iskormovaca", 5, 4, 500);

            Assert.AreEqual(500, pl1.getScore());
        }

        [TestMethod]
        public void PlayerTestMethod8()
        {
            Player pl1 = new Player(1, "iskormovaca", 5, 4, 500);

            pl1.setScore(1500);

            Assert.AreEqual(1500, pl1.getScore());
        }
    }
}
