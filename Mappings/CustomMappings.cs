using AutoMapper;
using LeaveManagement.Data.Entities;
using LeaveManagement.Models.ViewModels;

namespace LeaveManagement.Mappings
{
    public class CustomMappings : Profile
    {
        public CustomMappings()
        {
            CreateMap<LeaveType, LeaveTypeViewModel>();
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<LeaveHistory, LeaveHistoryViewModel>();
            CreateMap<LeaveAllocation, LeaveAllocationViewModel>();
        }
    }
}
