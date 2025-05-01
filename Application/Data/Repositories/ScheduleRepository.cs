using Application.Contexts;
using Application.Domain.Entities;
using Application.Interfaces;

namespace Application.Data.Repositories;

public class ScheduleRepository(DataContext context) : BaseRepository<ScheduleEntity>(context), IScheduleRepository
{

}


