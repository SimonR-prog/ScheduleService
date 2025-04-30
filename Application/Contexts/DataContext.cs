using Application.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Contexts;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public virtual DbSet<ScheduleEntity> Schedules { get; set; }
}
