namespace WebApplication1
{
    public class TasklService : ITasklService
    {
        public void Create(TaskModel taskmodel)
        {
            
                AllTasks.allTasks.Add(taskmodel);
        }

        public List<TaskModel> GetAllTasks()
        {

            return AllTasks.allTasks;
        }

        public TaskModel Update(int id, TaskModel taskmodel)
        {
            TaskModel tm = AllTasks.allTasks.Find(e => e.Id == id);
            tm.Title = taskmodel.Title;
            tm.Describe = taskmodel.Describe;
            tm.Date = taskmodel.Date;
            tm.Preferance = taskmodel.Preferance;
            return tm;
        }

        public void Delete(int id)
        {
            TaskModel tm = AllTasks.allTasks.Find(e => e.Id == id);
            AllTasks.allTasks.Remove(tm);
            
        }
    }
}