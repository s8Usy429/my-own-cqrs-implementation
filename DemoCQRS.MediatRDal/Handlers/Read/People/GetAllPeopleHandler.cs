using AutoMapper;
using DemoCQRS.Contracts.Dtos;
using DemoCQRS.Database;
using DemoCQRS.MediatRDal.Requests.Read.People;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DemoCQRS.MediatRDal.Handlers.Read.People
{
    public class GetAllPeopleHandler : IRequestHandler<GetAllPeopleRequest, IReadOnlyCollection<PeopleDto>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetAllPeopleHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IReadOnlyCollection<PeopleDto>> Handle(GetAllPeopleRequest request, CancellationToken cancellationToken)
        {
            return await _context.Peoples.AsNoTracking().Select(p => _mapper.Map<PeopleDto>(p)).ToArrayAsync(cancellationToken);
        }
    }
}
