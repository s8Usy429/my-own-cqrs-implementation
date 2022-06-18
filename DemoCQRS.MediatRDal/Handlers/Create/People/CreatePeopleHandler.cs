using AutoMapper;
using DemoCQRS.Database;
using DemoCQRS.Database.Entities;
using DemoCQRS.MediatRDal.Requests.Create.People;
using MediatR;

namespace DemoCQRS.MediatRDal.Handlers.Create.People
{
    public class CreatePeopleHandler : IRequestHandler<CreatePeopleRequest, int>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreatePeopleHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatePeopleRequest request, CancellationToken cancellationToken)
        {
            var addedEntity = await _context.Peoples.AddAsync(_mapper.Map<DbPeople>(request.People), cancellationToken);
            await _context.SaveChangesAsync();
            return addedEntity.Entity.Id;
        }
    }
}
