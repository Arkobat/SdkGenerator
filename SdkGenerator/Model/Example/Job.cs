namespace SdkGenerator.Model.Example;

public class Job
{
    public required string Title { get; set; }
    public required Company Company { get; set; }
    public required DateOnly StartedAt { get; set; }
}