namespace TwitterClone.Domain.Entities
{
    public class Like
    {   
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _likedAt;
        private DateTime _modifiedAt;


        public Like()
        {
            _id = Guid.NewGuid();
            _likedAt = DateTime.UtcNow;
        
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

        public DateTime LikedAt
        {
            get { return _likedAt; }
            set { _likedAt = value; }
        }


    }
}
