namespace Application.Domain.Models.Response;

public class BaseResponse
{
    public bool Success { get; set; }
    public int StatusCode { get; set; }
    public string? Message { get; set; }
}
