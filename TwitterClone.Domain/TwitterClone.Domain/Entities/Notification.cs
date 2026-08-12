namespace TwitterClone.Domain.Entities
{
    public class Notification
    {

        private Guid _id;
        private Guid _userId;
        private string type;

        public Notification()
        {

            _id = Guid.NewGuid();

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
