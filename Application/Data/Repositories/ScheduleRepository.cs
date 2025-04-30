using Application.Contexts;
using Application.Domain.Entities;

namespace Application.Data.Repositories;

public class ScheduleRepository(DataContext context) : BaseRepository<ScheduleEntity>(context)
{

}
