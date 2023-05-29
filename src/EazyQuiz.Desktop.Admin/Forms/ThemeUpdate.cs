using EazyQuiz.Models.DTO;

namespace EazyQuiz.Admin.Desktop;
public partial class ThemeUpdate : Form
{
    private readonly ApiProvider _apiProvider;

    private readonly List<ThemeResponseWithFlag> _themes = new();

    public ThemeUpdate(ApiProvider apiProvider)
    {
        InitializeComponent();
        _apiProvider = apiProvider;
    }

    public void Open()
    {
        Show();
    }

    private async void LoadThemes(object sender, EventArgs e)
    {
        _themes.AddRange(await _apiProvider.GetThemes());
        for (int i = 0; i < _themes.Count; i++)
        {
            var theme = _themes[i];
            ThemeList.Items.Add(theme, theme.Enabled);
        }
    }

    private async void UpdateAllThemes(object sender, EventArgs e)
    {
        var themes = new List<ThemeResponseWithFlag>();
        var list = (System.Collections.IList)ThemeList.Items;
        for (int i = 0; i < list.Count; i++)
        {
            var theme = list[i] as ThemeResponseWithFlag ?? new ThemeResponseWithFlag();

            if (ThemeList.GetItemCheckState(i) == CheckState.Checked)
            {
                theme.Enabled = true;
            }
            else
            {
                theme.Enabled = false;
            }
            themes.Add(theme);
        }
        await _apiProvider.UpdateThemes(themes);
    }
}
