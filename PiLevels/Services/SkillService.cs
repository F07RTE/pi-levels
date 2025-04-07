using System.Text.Json;

namespace PiLevels.Services.Skill;

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
        
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        return JsonSerializer.Deserialize<Models.Skill>(jsonContent, options) ?? 
            throw new Exception("Failed to load English skill data");
    }
}
