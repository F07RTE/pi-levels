namespace PiLevels.Models;

public class Level
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Icon { get; set; }
    public required List<Resource> Resources { get; set; } = [];
    public required string StudyPlan { get; set; }
    public required string Prize { get; set; }
    public required int LevelNumber { get; set; }
}
