using Application.Data.Repositories;
using Application.Domain.Forms;
using Application.Domain.Models;
using Application.Domain.Models.Response;
using Application.Internal.Factories;

namespace Application.Internal.Services;

public class ScheduleService(ScheduleRepository scheduleRepository)
{
    private readonly ScheduleRepository _scheduleRepository = scheduleRepository;


    public async Task<ScheduleResponse> AddSchedule(AddScheduleForm addForm)
    {
        try
        {
            if (addForm == null) { return new ScheduleResponse() { Success = false, StatusCode = 400, Message = "The form is null." }; }
            
            var entity = ScheduleFactory.Create(addForm);
            if (entity == null) { return new ScheduleResponse() { Success = false, StatusCode = 400, Message = "The entity is null." }; }

            var result = await _scheduleRepository.CreateAsync(entity);
            if (!result.Success) { return new ScheduleResponse() { Success = false, StatusCode = result.StatusCode, Message = result.Message }; }

            return new ScheduleResponse() { Success = true, StatusCode = 200 };
        }
        catch (Exception ex) { return new ScheduleResponse() { StatusCode = 500, Success = false, Message = $"{ex.Message}" }; }
    }

    public async Task<ScheduleResponse<EventSchedule>> GetSchedule(string id)
    {
        try
        {
            if (id == null) { return new ScheduleResponse<EventSchedule>() { Success = false, StatusCode = 400, Message = "Id is null.", Content = null }; }

            var result = await _scheduleRepository.GetAsync(entity => entity.EventId == id);
            if (result.Content == null) { return new ScheduleResponse<EventSchedule>() { Success = false, StatusCode = result.StatusCode, Message = result.Message, Content = null }; }

            var schedule = ScheduleFactory.Create(result.Content);
            if (schedule == null) { return new ScheduleResponse<EventSchedule>() { Success = false, StatusCode = 400, Message = "Schedule is null.", Content = null }; }

            return new ScheduleResponse<EventSchedule>() { Success = true, StatusCode = 200, Content = schedule };
        }
        catch (Exception ex) { return new ScheduleResponse<EventSchedule>() { StatusCode = 500, Success = false, Message = $"{ex.Message}", Content = null }; }
    }

    public async Task<ScheduleResponse> UpdateSchedule(UpdateScheduleForm updateForm)
    {
        try
        {
            if (updateForm == null) { return new ScheduleResponse() { Success = false, StatusCode = 400, Message = "The form is null." }; }
            
            var entity = ScheduleFactory.Create(updateForm);
            if (entity == null) { return new ScheduleResponse() { Success = false, StatusCode = 400, Message = "The entity is null." }; }

            var result = await _scheduleRepository.UpdateAsync(entity);
            if (!result.Success) { return new ScheduleResponse() { Success = false, StatusCode = result.StatusCode, Message = result.Message }; }

            return new ScheduleResponse() { Success = true, StatusCode = 200 };
        }
        catch (Exception ex) { return new ScheduleResponse() { StatusCode = 500, Success = false, Message = $"{ex.Message}" }; }
    }

    public async Task<ScheduleResponse> DeleteSchedule(string id)
    {
        try
        {
            if (id == null) { return new ScheduleResponse() { Success = false, StatusCode = 400, Message = "The id is null." }; }

            var entity = await _scheduleRepository.GetAsync(entity => entity.EventId == id);
            if (entity.Content == null) { return new ScheduleResponse() { Success = false, StatusCode = entity.StatusCode, Message = entity.Message }; }

            var result = await _scheduleRepository.DeleteAsync(entity.Content);
            if (!result.Success) { return new ScheduleResponse() { Success = false, StatusCode = result.StatusCode, Message = result.Message }; }

            return new ScheduleResponse() { Success = true, StatusCode = 200 };
        }
        catch (Exception ex) { return new ScheduleResponse() { StatusCode = 500, Success = false, Message = $"{ex.Message}" }; }
    }
}
