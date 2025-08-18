using AutoMapper;
using StudentDetailsApi.DTO;
using StudentDetailsApi.Model;

namespace StudentDetailsApi.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentDto, StudentTb>().ForMember(d => d.Address, opt => opt.MapFrom(s => s.Address)).ReverseMap();
            CreateMap<AddressDto, AddressTb>().ReverseMap();
        }
    }
}
