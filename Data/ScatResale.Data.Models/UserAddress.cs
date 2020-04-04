namespace ScatResale.Data.Models
{
    using ScatResale.Data.Common.Models;

    public class UserAddress
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
    }
}
