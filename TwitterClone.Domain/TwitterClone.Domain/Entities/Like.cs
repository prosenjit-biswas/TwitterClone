namespace TwitterClone.Domain.Entities
{
    internal class Like
    {
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _likedAt;


        public Like()
        {
            _userId = Guid.NewGuid();
            _tweetId = Guid.NewGuid();
            _likedAt = DateTime.UtcNow;
        
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public DateTime LikedAt
        {
            get { return _likedAt; }
        }


    }
}
