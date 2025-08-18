using AutoMapper;
using DapperTask.DTO;
using DapperTask.Models;
namespace DapperTask.AutoMapping
{
    public class AutoMappingFile : Profile
    {
        public AutoMappingFile()
        {
            CreateMap<StudentDTO,Students>().ReverseMap();
            CreateMap<AddressModelDTO, Addresses>().ReverseMap();
        }
    }
}
