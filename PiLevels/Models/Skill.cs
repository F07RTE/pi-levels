namespace PiLevels.Models;

public class Skill
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required List<Level> Levels { get; set; } = [];
    public List<SubSkill> SubSkills { get; set; } = [];
}
