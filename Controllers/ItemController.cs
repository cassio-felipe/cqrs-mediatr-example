using System;
using System.Threading.Tasks;
using CQRSMediatrExample.Domains.Commands.Itens.Requests;
using CQRSMediatrExample.Domains.Queries.Itens.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatrExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetItemById(Guid id)
        {
            var response = await _mediator.Send(new GetItemRequest{Id = id});
            return response == null ? NotFound() : Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddItem(CreateItemCommandRequest command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}