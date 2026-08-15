namespace TwitterClone.Domain.Entities
{
    public class Follow:BaseEntity
    {
   
        private Guid _followerId;
   

        public Follow():base(Guid.NewGuid())
        {
            
        }

        public Guid FollowerId
        {
            get { return _followerId; }
            set { _followerId = value; }
        }

    }
}