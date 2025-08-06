using AdvanceWebAPI.ModelEntity;
using AutoMapper;
using AdvanceWebAPI.DTO;

namespace AdvanceWebAPI.AutoMapping
{
    public class MappingOperations : Profile
    {
        public MappingOperations()
        {
            CreateMap<EmployeDetails,DummyDTO>().ReverseMap();
        }
    }
}
