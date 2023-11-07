namespace WebApplication1
{
    public interface ITasklService
    {
        public void Create(TaskModel taskmodel);
        public List<TaskModel> GetAllTasks();
        public TaskModel Update(int id, TaskModel taskmodel);
        public void Delete(int id);
        
    }
}
