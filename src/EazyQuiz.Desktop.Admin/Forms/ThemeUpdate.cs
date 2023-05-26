using EazyQuiz.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        ThemeList.
    }

    private async void LoadThemes(object sender, EventArgs e)
    {
        _themes.AddRange(await _apiProvider.GetAllThemes());
        foreach (var theme in _themes)
        {
            ThemeList.Items.Add(theme);
        }
    }

    private async void UpdateAllThemes(object sender, EventArgs e)
    {
        var themes = new List<ThemeResponseWithFlag>();
        foreach (ThemeResponseWithFlag theme in ThemeList.Items)
        {
            themes.Add(theme);
        }
        await _apiProvider.UpdateThemes(themes);
    }

    private void ThemeList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
