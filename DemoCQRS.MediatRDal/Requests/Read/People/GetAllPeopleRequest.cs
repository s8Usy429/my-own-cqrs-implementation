using DemoCQRS.Contracts.Dtos;
using MediatR;

namespace DemoCQRS.MediatRDal.Requests.Read.People
{
    public record GetAllPeopleRequest : IRequest<IReadOnlyCollection<PeopleDto>>;
}
