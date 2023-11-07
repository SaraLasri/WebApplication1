using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TasksController : ControllerBase
    {
        private readonly ITasklService TasklService;
        public TasksController(ITasklService TasklService)
        {
            this.TasklService = TasklService;
        }

        // GET: api/<TasksController>
        [HttpGet]
        public List<TaskModel> GetAllTasks()
        {
            return TasklService.GetAllTasks();
        }

        // POST api/<TasksController>
        [HttpPost("Create")]
        public void Create([FromBody] TaskModel tm) 
        {
            TasklService.Create(tm);
        }

        // PUT api/<TasksController>/5
        [HttpPut("{id}")]
        public TaskModel Put(int id, [FromBody] TaskModel value)
        {
           return TasklService.Update(id, value);
        }

        // DELETE api/<TasksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TasklService.Delete(id);
        }
    }
}
