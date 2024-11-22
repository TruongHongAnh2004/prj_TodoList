using todolist.Model;

namespace todolist.Sercives
{
    public class toDoServices
    {
        List<toDoListModel> toDoLists = new List<toDoListModel>();
        public List<toDoListModel> GetItemsForCategory(string category)
        {
            //if(category != null) { 
            //    toDoLists.Add(new toDoListModel { Id = 1, Name = "Homework" });
            //    toDoLists.Add(new toDoListModel { Id = 2, Name = "Eat" });
            //    toDoLists.Add(new toDoListModel { Id = 3, Name = "Sleep" });
            //}
            switch(category)
            {
                case "HomeItems":
					toDoLists.Add(new toDoListModel { Id = 1, Name = "Homework" });
					toDoLists.Add(new toDoListModel { Id = 2, Name = "Eat" });
					toDoLists.Add(new toDoListModel { Id = 3, Name = "Sleep" });
                    break;
				case "WorkItems":
					toDoLists.Add(new toDoListModel { Id = 1, Name = "Planing" });
					toDoLists.Add(new toDoListModel { Id = 2, Name = "Coding" });
					toDoLists.Add(new toDoListModel { Id = 3, Name = "Testing" });
					break;
                default:
					toDoLists.Add(new toDoListModel { Id = 1, Name = "Playing" });
					toDoLists.Add(new toDoListModel { Id = 2, Name = "Singing" });
					toDoLists.Add(new toDoListModel { Id = 3, Name = "Camping" });
					break;

			}
			return toDoLists;
        }
    }
}
