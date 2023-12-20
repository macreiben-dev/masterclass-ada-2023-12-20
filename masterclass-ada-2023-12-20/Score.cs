


namespace masterclass_ada_2023_12_20
{
    internal class Score
    {
        private int _servingPlayerScore;
        private int _receivingPlayerScore;
        private const string Love = "love";
        private const string Fifteen = "15";

        public Score()
        {
        }

        internal string CurrentScore()
        {
            return FormatScore(
                ComputeScore(_servingPlayerScore),
                ComputeScore(_receivingPlayerScore));
        }

        private string ComputeScore(int scoredPoint)
        {
            if(scoredPoint == 1)
            {
                return Fifteen;
            }

            return Love;
        }

        private static string FormatScore(string score1, string score2)
        {
            return $"{score1} - {score2}";
        }

        internal void ServingPlayerScores()
        {
            _servingPlayerScore = 1;
        }

        internal void ReceivingPlayerScores()
        {
            _receivingPlayerScore = 1;
        }
    }
}