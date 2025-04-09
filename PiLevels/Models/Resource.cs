namespace PiLevels.Models;

public class Resource
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? Link { get; set; }
    public string? FileName { get; set; }
}
