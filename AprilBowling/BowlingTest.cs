using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AprilBowling
{
    [TestClass]
    public class BowlingTest
    {
        private Bowling _bowling = new Bowling();

        [TestMethod]
        public void thorw_one_get_zero_score()
        {
            var roll = _bowling.RecordScore(0);

            Assert.AreEqual(0, roll);
        }

        [TestMethod]
        public void throw_one_get_one_score()
        {
            _bowling.RollBall(0);
            _bowling.RollBall(1);
            var score = _bowling.GetScore();
            Assert.AreEqual(1, score);
        }

        [TestMethod]
        public void throw_one_get_spare_score()
        {
            _bowling.RollBall(5);
            var score = _bowling.GetScore();
            Assert.AreEqual(5, score);
        }

        [TestMethod]
        public void throw_one_get_strike_score()
        {
            _bowling.RollBall(10);
            var score = _bowling.GetScore();
            Assert.AreEqual(10, score);
        }

        [TestMethod]
        public void throw_one_get_two_score()
        {
            Assert.AreEqual(2, _bowling.RecordScore(2));
        }

        [TestMethod]
        public void throw_three_get_strike_and_7_score_in_two_board()
        {
            _bowling.RollBall(10);
            _bowling.RollBall(6);
            _bowling.RollBall(1);

            var score = _bowling.GetScore();
            Assert.AreEqual(24, score);
        }

        [TestMethod]
        public void throw_three_get_two_strike_and_one_score_get_totalScore()
        {
            _bowling.RollBall(10);
            _bowling.RollBall(10);
            _bowling.RollBall(1);

            var score = _bowling.GetScore();
            Assert.AreEqual(21, score);
        }

        [TestMethod]
        public void throw_two_get_one_score()
        {
            _bowling.RollBall(0);
            _bowling.RollBall(1);
            var score = _bowling.GetScore();
            Assert.AreEqual(1, score);
        }
    }
}