// ReSharper disable VirtualMemberCallInConstructor
namespace ScatResale.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;
    using ScatResale.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();

            this.UserAddresses = new HashSet<UserAddress>();
            this.UserFavoriteProducts = new HashSet<UserFavoriteProduct>();
            this.Advertisements = new HashSet<Advertisement>();
            this.Inbox = new HashSet<Message>();
            this.SentBox = new HashSet<Message>();
        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<UserAddress> UserAddresses { get; set; }

        public virtual ICollection<UserFavoriteProduct> UserFavoriteProducts { get; set; }

        public virtual ICollection<Message> Inbox { get; set; }

        public virtual ICollection<Message> SentBox { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }
    }
}
