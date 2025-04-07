using System;

namespace PiLevels.Models;

public class SubSkill
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Level> Levels { get; set; } = [];
}
