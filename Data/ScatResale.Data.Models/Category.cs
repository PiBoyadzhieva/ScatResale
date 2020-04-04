namespace ScatResale.Data.Models
{
    using ScatResale.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public int MainCategoryId { get; set; }

        public virtual MainCategory MainCategory { get; set; }
    }
}
