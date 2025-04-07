using MudBlazor;

namespace SuperTraining.Blazor.Services;

public class ThemeService
{
    public static MudTheme GetTheme()
    {
        return new MudTheme
        {
            Palette = new PaletteLight
            {
                Black = "#000000",
                White = "#FFFFFF",
                Primary = "#0072CE", // Bright blue from logo
                Secondary = "#4CAF50", // Green from JORNADA DIGITAL
                Background = "#FFFFFF",
                Surface = "#FFFFFF",
                TextPrimary = "#1E1E1E",
                TextSecondary = "#666666",
                ActionDefault = "#0072CE",
                ActionDisabled = "#B0B0B0",
                ActionDisabledBackground = "#F5F5F5",
            },
            Typography = new Typography
            {
                Default = new Default { FontFamily = new[] { "Dela Gothic One", "cursive" } },
                H1 = new H1 { FontFamily = new[] { "Dela Gothic One", "cursive" } },
                H2 = new H2 { FontFamily = new[] { "Dela Gothic One", "cursive" } },
                H3 = new H3 { FontFamily = new[] { "Dela Gothic One", "cursive" } },
                H4 = new H4 { FontFamily = new[] { "Dela Gothic One", "cursive" } },
                H5 = new H5 { FontFamily = new[] { "Dela Gothic One", "cursive" } },
                H6 = new H6 { FontFamily = new[] { "Dela Gothic One", "cursive" } },
                Button = new Button { FontFamily = new[] { "Dela Gothic One", "cursive" } },
            },
        };
    }
}