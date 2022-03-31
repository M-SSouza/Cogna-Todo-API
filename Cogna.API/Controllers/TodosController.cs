using Cogna.Application.InputModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cogna.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        // GET: api/Todos
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // POST api/Todos
        [HttpPost]
        public IActionResult Post(AddTodoInputModel model)
        {
            return Ok();
        }

        // PUT api/Todos/5
        [HttpPut("{id}")]
        public IActionResult Put(UpdateTodoInputModel model)
        {
            return NoContent();
        }

        // DELETE api/<TodosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
