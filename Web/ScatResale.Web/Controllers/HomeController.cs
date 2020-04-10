namespace ScatResale.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using ScatResale.Data.Common.Repositories;
    using ScatResale.Data.Models;
    using ScatResale.Services.Mapping;
    using ScatResale.Web.ViewModels;
    using ScatResale.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IDeletableEntityRepository<MainCategory> mainCategoriesRepository;

        public HomeController(IDeletableEntityRepository<MainCategory> mainCategoriesRepository)
        {
            this.mainCategoriesRepository = mainCategoriesRepository;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var categories = this.mainCategoriesRepository.All()
                .To<IndexCategoryViewModel>()
                .ToList();

            viewModel.Categories = categories;

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
