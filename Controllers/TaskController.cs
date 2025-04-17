using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Task_Management.Model;

namespace Task_Management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        private readonly ITask _task;

        public TaskController(ITask task)
        {
            _task = task;
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var tasks = _task.GetAll();
            return Json(tasks);
        }

        [HttpGet("id")]
        public JsonResult Get(int id)
        {
            var tasks = _task.Get(id);
            return Json(tasks);
        }

        [HttpPost]
        public IActionResult create(Tasks tasks)
        {
            var task = _task.Create(tasks);
            return Ok(task);
        }

        [HttpDelete]
        public IActionResult delete(int id)
        {
            var task = _task.Delete(id);
            return Ok(task);
        }

        [HttpPatch]
        public IActionResult update(Tasks tasks)
        {
            var task = _task.Update(tasks);
            return Ok(task);    
        }

    }
}
