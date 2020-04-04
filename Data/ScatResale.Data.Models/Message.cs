namespace ScatResale.Data.Models
{
    using ScatResale.Data.Common.Models;

    public class Message : BaseDeletableModel<int>
    {
        public string Content { get; set; }

        public string SenderId { get; set; }

        public ApplicationUser Sender { get; set; }

        public string ReceiverId { get; set; }

        public ApplicationUser Receiver { get; set; }
    }
}
