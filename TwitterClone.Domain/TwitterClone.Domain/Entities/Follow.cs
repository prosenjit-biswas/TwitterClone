namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _id;
        private Guid _followerId;
        private DateTime _followedAt;

        public Follow()
        {
            _id = Guid.NewGuid();
           
            _followedAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid FollowerId
        {
            get { return _followerId; }
            set { _followerId = value; }
        }

        public DateTime FollowedAt
        {
            get { return _followedAt; }
        }
    }
}