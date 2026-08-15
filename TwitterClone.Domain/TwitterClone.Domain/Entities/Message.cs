namespace TwitterClone.Domain.Entities
{
    public class Message:BaseEntity
    {
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private bool _isRead;
 

        public Message(Guid Sender_id, string Content):base(Guid.NewGuid())
        {
            _senderId = Sender_id;
            _content = Content;
            _isRead = false;
            
        }

        public Guid SenderId
        {
            get { return _senderId; }
           // set { _senderId = value; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
            set { _receiverId = value; }
        }

        public string Content
        {
            get { return _content; }
           // set { _content = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

    }
}