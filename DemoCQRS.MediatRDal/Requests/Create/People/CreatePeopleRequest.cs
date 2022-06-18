using DemoCQRS.Contracts.Dtos;
using MediatR;

namespace DemoCQRS.MediatRDal.Requests.Create.People
{
    public record CreatePeopleRequest(PeopleDto People) : IRequest<int>;
}
