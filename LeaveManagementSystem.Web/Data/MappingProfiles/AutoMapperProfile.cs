using AutoMapper;
using LeaveManagementSystem.Web.Models.LeaveTypes;
namespace LeaveManagementSystem.Web.Data.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // CreateMap<Source, Destination>()
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            //.ForMember(dest => dest.Days, opt => opt.MapFrom(src => src.NumberOfDays));
            CreateMap<LeaveTypeCreateVM, LeaveType>();
            //.ForMember(dest => dest.Id, opt => opt.Ignore()); // Ignore Id during creation
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();


        }
    }
}
