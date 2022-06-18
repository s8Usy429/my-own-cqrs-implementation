using AutoMapper;
using DemoCQRS.Contracts.Dtos;
using DemoCQRS.Database.Entities;

namespace DemoCQRS.MediatRDal
{
    public class DbEntitesAutoMapperProfile : Profile
    {
        public DbEntitesAutoMapperProfile()
        {
            this.CreateMap<DbPeople, PeopleDto>();
            this.CreateMap<PeopleDto, DbPeople>();
        }
    }
}
