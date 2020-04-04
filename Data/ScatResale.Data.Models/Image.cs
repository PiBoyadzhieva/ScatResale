namespace ScatResale.Data.Models
{
    using ScatResale.Data.Common.Models;

    public class Image : BaseDeletableModel<int>
    {
        public string ImageUrl { get; set; }

        public int AdvertisementId { get; set; }

        public virtual Advertisement Advertisement { get; set; }
    }
}
