namespace ScatResale.Data.Models
{
    using System.Collections.Generic;

    using ScatResale.Data.Common.Models;

    public class MainCategory : BaseDeletableModel<int>
    {
        public MainCategory()
        {
            this.Categories = new HashSet<Category>();
        }

        public string Name { get; set; }

        public string Icon { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
