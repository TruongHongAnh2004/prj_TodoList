using Microsoft.AspNetCore.Mvc;
using todolist.Sercives;
using todolist.ViewModels;

namespace todolist.Controllers
{
	public class toDoController : Controller
	{
		private readonly toDoServices _services;
        public toDoController(toDoServices service)
        {
            _services = service;
        }
        public ActionResult Category(string category) { 
        CategoryViewModel viewModel = new CategoryViewModel();
            viewModel.ListModels = _services.GetItemsForCategory(category);
            return View(viewModel);
        }
    }
}
