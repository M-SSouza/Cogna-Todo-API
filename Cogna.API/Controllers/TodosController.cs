using Cogna.Application.InputModels;
using Cogna.Application.Services.Todos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cogna.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodosService _todosService;
        public TodosController(ITodosService todosService)
        {
            _todosService = todosService;
        }

        // GET: api/Todos
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_todosService.GetAll());
        }

        // POST api/Todos
        [HttpPost]
        public IActionResult Post(AddTodoInputModel model)
        {
            _todosService.Add(model);

            return Ok();
        }

        // PUT api/Todos/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateTodoInputModel model)
        {
            bool success = _todosService.Update(id, model);

            if (success)
                return NotFound();

            return NoContent();
        }

        // DELETE api/Todos/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool success = _todosService.Delete(id);

            if (success)
                return NotFound();

            return Ok();
        }
    }
}
