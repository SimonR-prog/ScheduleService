using Application.Domain.Entities;
using Application.Domain.Forms;
using Application.Domain.Models;

namespace Application.Internal.Factories;
public class ScheduleFactory
{
    public static ScheduleEntity Create(AddScheduleForm addForm)
    {
        if (addForm == null) return null!;

        var scheduleEntity = new ScheduleEntity() 
        { 
            EventId = addForm.EventId,
            GateOpenStart = addForm.GateOpenStart,
            GateOpenEnd = addForm.GateOpenEnd,
            PreShowStart = addForm.PreShowStart,
            PreShowEnd = addForm.PreShowEnd,
            CeremonyStart = addForm.CeremonyStart,
            CeremonyEnd = addForm.CeremonyEnd,
            ConcertStart = addForm.ConcertStart,
        };
        return scheduleEntity;
    }

    public static ScheduleEntity Create(UpdateScheduleForm updateForm)
    {
        if (updateForm == null) return null!;

        var scheduleEntity = new ScheduleEntity()
        {
            EventId = updateForm.EventId,
            GateOpenStart = updateForm.GateOpenStart,
            GateOpenEnd = updateForm.GateOpenEnd,
            PreShowStart = updateForm.PreShowStart,
            PreShowEnd = updateForm.PreShowEnd,
            CeremonyStart = updateForm.CeremonyStart,
            CeremonyEnd = updateForm.CeremonyEnd,
            ConcertStart = updateForm.ConcertStart,
        };
        return scheduleEntity;
    }

    public static EventSchedule Create(ScheduleEntity entity)
    {
        if (entity == null) return null!;

        var eventSchedule = new EventSchedule()
        {
            EventId = entity.EventId,
            GateOpenStart = entity.GateOpenStart,
            GateOpenEnd = entity.GateOpenEnd,
            PreShowStart = entity.PreShowStart,
            PreShowEnd = entity.PreShowEnd,
            CeremonyStart = entity.CeremonyStart,
            CeremonyEnd = entity.CeremonyEnd,
            ConcertStart = entity.ConcertStart,
        };
        return eventSchedule;
    }
}
