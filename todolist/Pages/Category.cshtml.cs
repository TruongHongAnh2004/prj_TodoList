using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using todolist.Model;
using todolist.Sercives;

namespace todolist.Pages
{
    public class CategoryModel : PageModel
    {
        private readonly toDoServices _servicel;
        public CategoryModel(toDoServices service)
        {
            _servicel = service;
        }
        public ActionResult OnGet(string category) 
        {
            category = "todolist";
            Items = _servicel.GetItemsForCategory(category);
            return Page();
        }
        public List<toDoListModel> Items { get; set; }
    }
}
