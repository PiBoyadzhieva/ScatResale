namespace ScatResale.Data.Models
{
    using System;
    using System.Collections.Generic;

    using ScatResale.Data.Common.Models;

    public class Advertisement : BaseDeletableModel<int>
    {
        public Advertisement()
        {
            this.UserFavoriteProducts = new HashSet<UserFavoriteProduct>();
            this.Images = new HashSet<Image>();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int ViewsCount { get; set; }

        public DateTime ActiveTo => this.CreatedOn.AddMonths(1);

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<UserFavoriteProduct> UserFavoriteProducts { get; set; }

        public int MainCategoryId { get; set; }

        public virtual MainCategory MainCategory { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string SellerId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
    }
}
