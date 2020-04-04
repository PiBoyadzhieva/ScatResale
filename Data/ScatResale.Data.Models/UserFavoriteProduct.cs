namespace ScatResale.Data.Models
{
    using ScatResale.Data.Common.Models;

    public class UserFavoriteProduct : BaseDeletableModel<int>
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int AdvertisementId { get; set; }

        public virtual Advertisement Advertisement { get; set; }
    }
}
