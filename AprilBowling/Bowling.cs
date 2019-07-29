namespace AprilBowling
{
    public class Bowling
    {
        private static int RollCount = 1;
        private int maxScore = 10;
        private int strikeRecord = 0;
        private int temperareScore = 0;
        private int totalScore = 0;

        public int GetScore()
        {
            return totalScore;
        }

        public int RecordScore(int score)
        {
            if (strikeRecord != 0 || RollCount == 2)
            {
                RollCount++;
                if (strikeRecord == 1)
                {
                    totalScore += score;
                    temperareScore = 0;
                    strikeRecord--;
                    RollCount = 1;
                }
                else
                {
                    temperareScore += score;
                    temperareScore *= 2;//14
                }

                totalScore += temperareScore;//20

                return totalScore;
            }

            temperareScore += score;
            if (temperareScore != 0 && RollCount == 2)
            {
                return totalScore += temperareScore;
            }
            RollCount++;
            return totalScore;
        }

        public void RollBall(int score)
        {
            if (!isStrike(score))
            {
                RecordScore(score);
            }
            else
            {
                strikeRecord++;
                if (RollCount == 2 || strikeRecord != 0)
                {
                    RecordScore(score);
                }
                else
                {
                    RollCount = 1;
                }
            }
        }

        private bool isStrike(int score)
        {
            return score == maxScore;
        }
    }
}