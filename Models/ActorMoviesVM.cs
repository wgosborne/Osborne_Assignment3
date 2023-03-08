namespace Osborne_Assignment3.Models
{
    public class ActorMoviesVM
    {
        public Actor Actor { get; set; }

        public List<Movie> Movies { get; set; }

        //public double AverageTweetSentiment()
        //{
        //    if (Tweets == null) return 0;
        //    int validTweets = 0;
        //    double totalTweetScore = 0;
        //    foreach (MovieTweet tweet in Tweets)
        //    {
        //        if (tweet.Sentiment != 0)
        //        {
        //            validTweets++;
        //            totalTweetScore += tweet.Sentiment;
        //        }
        //    }
        //    return totalTweetScore / validTweets;
        //}
    }
}
