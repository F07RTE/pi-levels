namespace PiLevels.Models;

public class Level
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required string Icon { get; set; }
    public required List<Resource> Resources { get; set; } = [];
    public string? StudyPlan { get; set; }
    public string? Prize { get; set; }
    public required int LevelNumber { get; set; }
}
