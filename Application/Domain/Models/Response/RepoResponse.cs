namespace Application.Domain.Models.Response;

public class RepoResponse : BaseResponse
{
}
public class RepoResponse<T> : RepoResponse
{
    public T? Content { get; set; }
}