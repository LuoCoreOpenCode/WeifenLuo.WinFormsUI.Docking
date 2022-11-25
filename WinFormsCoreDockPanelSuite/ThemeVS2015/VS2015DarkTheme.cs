namespace WinFormsCoreDockPanelSuite.ThemeVS2015
{

    /// <summary>
    /// Visual Studio 2015 Dark theme.
    /// </summary>
    public class VS2015DarkTheme : VS2015ThemeBase
    {
        public VS2015DarkTheme()
            : base(Decompress(Resources.vs2015dark_vstheme))
        {
        }
    }
}
