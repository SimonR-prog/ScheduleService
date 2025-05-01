namespace Application.Domain.Forms;

public class AddScheduleForm
{
    public string EventId { get; set; } = null!;
    public string GateOpenStart { get; set; } = null!;
    public string GateOpenEnd { get; set; } = null!;
    public string? PreShowStart { get; set; }
    public string? PreShowEnd { get; set; }
    public string? CeremonyStart { get; set; }
    public string? CeremonyEnd { get; set; }
    public string ConcertStart { get; set; } = null!;
}
