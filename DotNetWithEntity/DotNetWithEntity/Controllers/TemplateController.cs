using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetWithEntity.Interfaces;
using DotNetWithEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWithEntity.Controllers
{
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class TemplateController : ControllerBase
    {
        private ITemplateService _service;

        public TemplateController(ITemplateService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get all templates
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET
        ///     [template : {
        ///        "id": 1,
        ///        "name": "Item1"
        ///     }]
        ///
        /// </remarks>
        /// <param name="client"></param>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpGet("Cpf/NmDependents")]
        [ProducesResponseType(typeof(Client), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Template>>> Get([FromRoute] Client client)
        {
            var result = await _service.GetTemplates(client);
            if (!result.Any())
                return NotFound();

            return Ok(result);
        }

        /// <summary>
        /// Create template
        /// </summary>
        /// <param name="template"></param>
        [HttpPost]
        [ProducesResponseType(typeof(Template), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post([FromBody] Template template)
        {
            var result = await _service.Create(template);
            return Created(nameof(Get), result);
        }

        /// <summary>
        /// Update template
        /// </summary>
        /// <param name="template"></param>
        [HttpPut]
        [ProducesResponseType(typeof(Template), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Put([FromBody] Template template)
        {
            await _service.Update(template);
            return NoContent();
        }
    }
}