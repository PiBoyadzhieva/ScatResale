namespace ScatResale.Data.Models
{
    using System.Collections.Generic;

    using ScatResale.Data.Common.Models;

    public class Address : BaseDeletableModel<int>
    {
        public Address()
        {
            this.Advertisements = new HashSet<Advertisement>();
            this.UserAddresses = new HashSet<UserAddress>();
        }

        public string Country { get; set; }

        public string Town { get; set; }

        public string District { get; set; }

        public string Street { get; set; }

        public int ZipCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public virtual ICollection<UserAddress> UserAddresses { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }
    }
}
