using todolist.Model;

namespace todolist.Sercives
{
    public class toDoServices
    {
        List<toDoListModel> toDoLists = new List<toDoListModel>();
        public List<toDoListModel> GetItemsForCategory(string category)
        {
            if(category != null) { 
                toDoLists.Add(new toDoListModel { Id = 1, Name = "Homework" });
                toDoLists.Add(new toDoListModel { Id = 2, Name = "Eat" });
                toDoLists.Add(new toDoListModel { Id = 3, Name = "Sleep" });
            }
            return toDoLists;
        }
    }
}
