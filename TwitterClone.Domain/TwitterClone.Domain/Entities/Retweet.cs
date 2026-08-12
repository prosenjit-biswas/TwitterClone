namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _retweetedAt;

        public Retweet()
        {
            _id = Guid.NewGuid();
            _retweetedAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }

        public DateTime RetweetedAt
        {
            get { return _retweetedAt; }
        }
    }
}