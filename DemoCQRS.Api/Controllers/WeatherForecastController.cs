using DemoCQRS.Contracts.Dtos;
using DemoCQRS.MediatRDal.Requests.Create.People;
using DemoCQRS.MediatRDal.Requests.Read.People;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoCQRS.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IReadOnlyCollection<PeopleDto>> Get()
        {
            return await _mediator.Send(new GetAllPeopleRequest());
        }

        [HttpPost]
        public async Task<int> Create(PeopleDto people)
        {
            return await _mediator.Send(new CreatePeopleRequest(people));
        }
    }
}