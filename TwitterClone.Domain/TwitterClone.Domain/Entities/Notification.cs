namespace TwitterClone.Domain.Entities
{
    public class Notification:BaseEntity
    {

        private Guid _userId;
        private string type;

        public Notification():base(Guid.NewGuid())
        {

            

        }

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }

        }

        public string Type
        {
            get { return type; }
            set { type = value;  }
        }



    }
}
