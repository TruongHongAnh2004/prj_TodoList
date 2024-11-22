using todolist.Model;

namespace todolist.ViewModels
{
	public class CategoryViewModel
	{
		public IEnumerable<toDoListModel> ListModels {get;set;}
		public string currentCategory { get; set; }

    }
}
