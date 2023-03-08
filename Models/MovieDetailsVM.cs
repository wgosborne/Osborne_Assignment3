namespace Osborne_Assignment3.Models
{
    public class MovieDetailsVM
    {
        public Movie movie { get; set; }
        public List<MovieTweet>? Tweets { get; set; }
        public double AvTweetSentiment()
        {
            if (Tweets == null) return 0;
            int tweetCount = 0;
            double totalTweetSentiment = 0;
            foreach (MovieTweet tweet in Tweets)
            {
                if (tweet.Sentiment != 0)
                {
                    tweetCount++;
                    totalTweetSentiment += tweet.Sentiment;
                }
            }
            return totalTweetSentiment / tweetCount;
        }

    }
}
