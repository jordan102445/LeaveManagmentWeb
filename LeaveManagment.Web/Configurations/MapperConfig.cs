using AutoMapper;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;

namespace LeaveManagment.Web.Configurations
{
    public class MapperConfig : Profile // Profile e od AutoMapper
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM_View_Model_>().ReverseMap();  // convert from data model to view model(na korisnickiot interfejs)
            
        }

    }
}
