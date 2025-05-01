using Application.Domain.Forms;
using Application.Domain.Models;
using Application.Domain.Models.Response;

namespace Application.Interfaces
{
    public interface IScheduleService
    {
        Task<ScheduleResponse> AddScheduleAsync(AddScheduleForm addForm);
        Task<ScheduleResponse> DeleteScheduleAsync(string id);
        Task<ScheduleResponse<EventSchedule>> GetScheduleAsync(string id);
        Task<ScheduleResponse> UpdateScheduleAsync(UpdateScheduleForm updateForm);
    }
}