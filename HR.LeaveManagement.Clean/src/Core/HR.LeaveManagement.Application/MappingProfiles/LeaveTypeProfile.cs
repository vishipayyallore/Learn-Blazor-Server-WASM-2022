using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.MappingProfiles;

public class LeaveTypeProfile : Profile
{
    public LeaveTypeProfile()
    {
        _ = CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();

        _ = CreateMap<LeaveType, LeaveTypeDetailsDto>();

        //CreateMap<CreateLeaveTypeCommand, LeaveType>();
        //CreateMap<UpdateLeaveTypeCommand, LeaveType>();
    }
}