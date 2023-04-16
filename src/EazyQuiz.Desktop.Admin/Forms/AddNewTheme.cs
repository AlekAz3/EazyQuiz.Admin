namespace EazyQuiz.Admin.Desktop;

/// <summary>
/// Форма для добавления новой темы
/// </summary>
public partial class AddNewTheme : Form
{
    /// <inheritdoc cref="ApiProvider"/>
    private readonly ApiProvider _apiProvider;

    public AddNewTheme(ApiProvider apiProvider)
    {
        InitializeComponent();
        _apiProvider = apiProvider;
    }

    /// <summary>
    /// Открыть окно
    /// </summary>
    public void Open()
    {
        Show();
    }

    /// <summary>
    /// Добавить тему кнопка
    /// </summary>
    private async void AddThemeButtonClick(object sender, EventArgs e)
    {
        var a = MessageBox.Show("Вы уверены", "Внимание", MessageBoxButtons.YesNo);
        if (a == DialogResult.Yes)
        {
            var text = textBox1.Text;
            await _apiProvider.SendNewTheme(text);
            textBox1.Text = "";
        }
    }
}
