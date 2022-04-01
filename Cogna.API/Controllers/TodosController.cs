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
        /// <summary>
        /// Recupera todos os registros TODOs.
        /// </summary>
        /// <returns>Lista de TODOs.</returns>
        /// <response code="200">Sucesso.</response>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_todosService.GetAll());
        }

        // POST api/Todos
        /// <summary>
        /// Cadastra um novo TODO.
        /// </summary>
        /// <param name="model">Informações do novo TODO.</param>
        /// <returns>TODO criado.</returns>
        /// <response code="200">Sucesso.</response>
        [HttpPost]
        public IActionResult Post(AddTodoInputModel model)
        {
            _todosService.Add(model);

            return Ok();
        }

        // PUT api/Todos/5
        /// <summary>
        /// Modifica um TODO.
        /// </summary>
        /// <param name="id">Id do TODO a ser modificado.</param>
        /// <param name="model">Informações do TODO a ser modificado.</param>
        /// <returns>TODO editado.</returns>
        /// <response code="404">Algo não ocorreu bem.</response>
        /// <response code="204">Modificado.</response>
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateTodoInputModel model)
        {
            bool success = _todosService.Update(id, model);

            if (!success)
                return NotFound();

            return NoContent();
        }

        // DELETE api/Todos/5
        /// <summary>
        /// Deleta um TODO.
        /// </summary>
        /// <param name="id">Id do TODO a ser deletado.</param>
        /// <returns>TODO deletado.</returns>
        /// <response code="404">Algo não ocorreu bem.</response>
        /// <response code="200">Sucesso.</response>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool success = _todosService.Delete(id);

            if (!success)
                return NotFound();

            return Ok();
        }
    }
}
