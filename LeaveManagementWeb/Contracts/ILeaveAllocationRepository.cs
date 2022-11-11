using LeaveManagementWeb.Data;

namespace LeaveManagementWeb.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeid);
        Task<bool> AllocationExist(string employeeId, int leaveTypeId, int period);
    }
}
