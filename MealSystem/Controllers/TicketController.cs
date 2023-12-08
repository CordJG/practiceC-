using MealSystem.Libs;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MealSystem.Commons.Filters;
using MealSystem.DTO;
using MealSystem.Models;

namespace MealSystem.Controllers
{
    [ApiController]
    [Route("api/tickets")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class TicketController : ControllerBase
    {
       

        private readonly ILogger<TicketController> _logger;
        private readonly TicketLib _ticketLib;
        private readonly IMapper _mapper;
        public TicketController(ILogger<TicketController> logger, TicketLib tickectLib, IMapper mapper)

        {
            _logger = logger;
            _ticketLib = tickectLib;
            _mapper = mapper;
        }

        [HttpPost(Name = "PostTicket")]
        [ServiceFilter(typeof(ApiKeyAuthFilter))]
        public IActionResult PostTicket([FromBody]TicketDto _ticketDto)
        {
            _logger.LogDebug("TicketController -> PostTicket");

            var ticket = _mapper.Map<Ticket>(_ticketDto);

            return Ok(_ticketLib.AddTicket(ticket));

        }
    }
}
