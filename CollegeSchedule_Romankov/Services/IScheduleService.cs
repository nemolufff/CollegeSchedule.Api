using CollegeSchedule_Romankov.DTO;

namespace CollegeSchedule_Romankov.Services
{
    public interface IScheduleService
    {
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime startDate, DateTime endDate);
    }
}