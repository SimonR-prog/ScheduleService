namespace Application.Domain.Models.Response;

public class ScheduleResponse : BaseResponse
{
}
public class ScheduleResponse<T> : ScheduleResponse
{
    public T? Content { get; set; }
}
