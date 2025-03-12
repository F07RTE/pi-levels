using System.Text.Json;
using PiLevels.Models;

namespace PiLevels.Services;

public class SkillService
{
    private readonly IWebHostEnvironment _environment;

    public SkillService(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    public async Task<Models.Skill> GetEnglishSkillAsync()
    {
        var filePath = Path.Combine(_environment.ContentRootPath, "Data", "english-skill.json");
        var jsonContent = await File.ReadAllTextAsync(filePath);
        return JsonSerializer.Deserialize<Models.Skill>(jsonContent) ?? throw new Exception("Failed to load English skill data");
    }
}
