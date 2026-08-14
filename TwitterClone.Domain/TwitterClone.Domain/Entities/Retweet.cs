namespace TwitterClone.Domain.Entities
{
    public class Retweet:BaseEntity
    {
       
        private Guid _userId;
        private Guid _tweetId;
        private string _comment;

        public Retweet(string comment):base(Guid.NewGuid())   
        {
            _comment = comment;
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

    }
}