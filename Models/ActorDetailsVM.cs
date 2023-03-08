namespace Osborne_Assignment3.Models
{
    public class ActorDetailsVM
    {
        public Actor actor { get; set; }
        public List<ActorTweet>? Tweets { get; set; }
        public double AvTweetSentiment()
        {
            if (Tweets == null) return 0;
            int tweetCount = 0;
            double totalTweetSentiment = 0;
            foreach (ActorTweet tweet in Tweets)
            {
                if (tweet.Sentiment != 0)
                {
                    tweetCount ++;
                    totalTweetSentiment += tweet.Sentiment;
                }
            }
            return totalTweetSentiment / tweetCount;
        }
    }
}
