﻿using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

public class GetLeaveTypesQueryHandler : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    // private readonly IAppLogger<GetLeaveTypesQueryHandler> _logger;

    public GetLeaveTypesQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
    {
        this._mapper = mapper;
        this._leaveTypeRepository = leaveTypeRepository;
        // this._logger = logger;
    }

    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var leaveTypes = await _leaveTypeRepository.GetAsync();

        // convert data objects to DTO objects
        var data = _mapper.Map<List<LeaveTypeDto>>(leaveTypes);

        // return list of DTO object
        // _logger.LogInformation("Leave types were retrieved successfully");

        return data;
    }
}
