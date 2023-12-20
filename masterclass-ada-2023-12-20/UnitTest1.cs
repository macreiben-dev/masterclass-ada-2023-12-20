using NFluent;

namespace masterclass_ada_2023_12_20
{
    public class UnitTest1
    {
        [Fact]
        public void When_matchStarts_Then_score_is_love_love()
        {
            var target = new Score();

            var actual = target.CurrentScore();

            Check.That(actual).IsEqualTo("love - love");
        }

        [Fact]
        public void GIVEN_matchStarts_AND_serverPlayer_scores_onePoint_THEN_score_is_fifteen_love()
        {
            var target = new Score();

            target.ServingPlayerScores();

            var actual = target.CurrentScore();

            Check.That(actual).IsEqualTo("15 - love");
        }

        [Fact]
        public void GIVEN_servingPlayer_scores_AND_receivingPlayer_scores_THEN_score_is_fifteen_fifteen()
        {
            var target = new Score();

            target.ServingPlayerScores();
            target.ReceivingPlayerScores();

            var actual = target.CurrentScore();

            Check.That(actual).IsEqualTo("15 - 15");
        }

        [Fact]
        public void GIVEN_matchStarts_AND_receivingPlayer_scores_THEN_score_is_love_fifteen()
        {
            var target = new Score();

            target.ReceivingPlayerScores();

            var actual = target.CurrentScore();

            Check.That(actual).IsEqualTo("love - 15");
        }
    }
}