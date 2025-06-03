using MudBlazor;

namespace Nethereum.GnosisValidator
{
    public static class Theme
    {
        // base numbers ↓ are ~15-20 % smaller than MudBlazor defaults
        private const string Base = ".75rem";   // -25 %  (≈12 px)
        private const string BaseStrong = ".8125rem"; // body-1
        private const string Subtle = ".6875rem"; // caption / hint

        public static readonly MudTheme SafeUtilsTheme = new()
        {
            PaletteLight = new PaletteLight
            {
                Primary = Colors.Blue.Darken2,
                Secondary = Colors.Green.Accent4,
                Background = Colors.Gray.Lighten5,
                Surface = "rgba(255,255,255,0.85)",
                AppbarBackground = "#263238",
            },
            PaletteDark = new PaletteDark
            {
                Primary = Colors.BlueGray.Lighten2,
                Secondary = Colors.Green.Lighten1,
                Background = Colors.Gray.Lighten5,
                Surface = "rgba(30,30,30,0.85)"
            },

            //Typography = new Typography
            //{
            //    // BODY TEXT  ───────────────────────────────────────
            //    Default = new DefaultTypography { FontSize = Base },
            //    Body1 = new Body1Typography { FontSize = BaseStrong },
            //    Body2 = new Body2Typography { FontSize = Base },
            //    Caption = new CaptionTypography { FontSize = Subtle },
            //    Button = new ButtonTypography { FontSize = Base },

            //    // HEADINGS  ────────────────────────────────────────
            //    H3 = new H3Typography { FontSize = "1.35rem", FontWeight = "600" },   // was 1.75rem
            //    H4 = new H4Typography { FontSize = "1.15rem", FontWeight = "600" },
            //    H5 = new H5Typography { FontSize = "1rem", FontWeight = "600" },
            //    H6 = new H6Typography { FontSize = ".875rem", FontWeight = "700" },

            //    // SUB-HEADINGS / LABELS
            //    Subtitle1 = new Subtitle1Typography { FontSize = BaseStrong },
            //    Subtitle2 = new Subtitle2Typography { FontSize = Base },

            //    // OVERLINE

            //    Overline = new OverlineTypography { FontSize = Subtle }
            //},

            // keep paddings/tabs/etc. tight as well
            LayoutProperties = new LayoutProperties
            {
                DefaultBorderRadius = "10px",
                DrawerWidthLeft = "220px"
            }
        };
    }
}
