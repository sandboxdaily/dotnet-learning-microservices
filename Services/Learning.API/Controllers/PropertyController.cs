using Learning.Application.Commands.Property.AddProperty;
using Learning.Application.Commands.Property.UpdateProperty;
using Learning.Application.Queries.Property.GetProperties;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Learning.API.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly ISender _sender;

        public PropertyController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost]
        public async Task<ActionResult<AddPropertyResult>> AddProperty (
            [FromBody] AddPropertyCommand request, CancellationToken cancellationToken)
        {
            var result = await _sender.Send(request, cancellationToken);

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<UpdatePropertyResult>> UpdateProperty(
            [FromBody] UpdatePropertyCommand request, CancellationToken cancellationToken)
        {
            var result = await _sender.Send(request, cancellationToken);

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<GetPropertiesQuery>> GetProperties(
            [FromQuery] GetPropertiesQuery request, CancellationToken cancellationToken)
        {
            var result = await _sender.Send(request, cancellationToken);

            return Ok(result);
        }
    }
}
