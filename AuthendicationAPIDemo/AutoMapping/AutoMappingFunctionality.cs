using AuthendicationAPIDemo.DTO;
using AuthendicationAPIDemo.Models;
using AutoMapper;   
namespace AuthendicationAPIDemo.AutoMapping
{
    public class AutoMappingFunctionality : AutoMapper.Profile
    {
        public AutoMappingFunctionality()
        {
            CreateMap<DummyUser, UserAuthendication>();
            CreateMap<UserAuthendication, DummyUser>();
        }
    }
}
