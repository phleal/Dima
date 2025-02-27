﻿using MudBlazor;

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
                Primary = "#1EFA2D",
                Secondary = Colors.LightGreen.Darken3,
                Background = Colors.Grey.Lighten4,
                AppbarBackground = "#1EFA2D",
                AppbarText = Colors.Shades.Black,
                TextPrimary = Colors.Shades.Black,
                PrimaryContrastText = Colors.Shades.Black,
                DrawerText = Colors.Shades.Black,
                DrawerBackground = Colors.LightGreen.Lighten4
            },

            PaletteDark = new PaletteDark()
            {
                Primary = Colors.LightGreen.Accent3,
                Secondary = Colors.LightGreen.Darken3,
                AppbarBackground = Colors.LightGreen.Accent3,
                AppbarText = Colors.Shades.Black,
                // Background = Colors.Grey.Lighten4,
                // TextPrimary = Colors.Shades.Black,
                // DrawerText = Colors.Shades.Black,
                // DrawerBackground = Colors.LightGreen.Lighten4
            }
        };
    }
}
