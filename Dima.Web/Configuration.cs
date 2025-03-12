using MudBlazor;
using MudBlazor.Utilities;

namespace Dima.Web
{
    public static class Configuration
    {
        public const string HttpClientName = "dima";

        public static string BackendUrl { get; set; } =  "http://localhost:5164";

        public static MudTheme Theme = new()
        {
            Typography = new Typography
            {
                Default = new Default()
                {
                    FontFamily = ["Raleway", "sans-serif"]
                }
            },
            Palette = new PaletteLight
            {
                Primary = new MudColor("#D4A373"),
                PrimaryContrastText = new MudColor("#E6E6E6"),
                Secondary = Colors.LightGreen.Darken3,
                Background = Colors.Grey.Lighten4,
                AppbarBackground = new MudColor("#82AC93"),
                AppbarText = Colors.Shades.Black,
                TextPrimary = Colors.Shades.Black,
                DrawerText = Colors.Shades.White,
                DrawerBackground = new MudColor("#4C725C")
            },

            //PaletteDark = new PaletteDark()
            //{
            //    Primary = Colors.LightGreen.Accent3,
            //    Secondary = Colors.LightGreen.Darken3,
            //    AppbarBackground = new MudColor("#5F8C72"),
            //    AppbarText = Colors.Shades.Black,
            //    PrimaryContrastText = new MudColor("#000000"),
            //    Background = Colors.Grey.Lighten4,
            //}

            PaletteDark = new PaletteDark()
            {
                Primary = new MudColor("#D4A373"), // Dourado suave para botões e elementos principais
                Secondary = Colors.LightGreen.Darken3, // Mantendo a identidade com verde escuro
                AppbarBackground = new MudColor("#4A6A59"), // Verde escuro para melhor contraste
                AppbarText = new MudColor("#F5F5F5"), // Texto claro para melhor leitura
                PrimaryContrastText = new MudColor("#F5F5F5"), // Melhor visibilidade nos botões
            }

        };
    }
}
