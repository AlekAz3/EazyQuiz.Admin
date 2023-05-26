namespace EazyQuiz.Admin.Desktop;

/// <summary>
/// Форма основной панели
/// </summary>
public partial class MainPanel : Form
{
    /// <inheritdoc cref="IFormFactory"/>
    private readonly IFormFactory _formFactory;

    public MainPanel(IFormFactory formFactory)
    {
        InitializeComponent();
        _formFactory = formFactory;
    }

    /// <summary>
    /// Открыть форму
    /// </summary>
    public void Open()
    {
        Show();
    }

    /// <summary>
    /// Открыть форму управления предложенными вопросами от пользователей 
    /// </summary>
    private void OpenUsersQuestionsPanel(object sender, EventArgs e)
    {
        var form = _formFactory.Create<ManageUsersQuestionPanel>();
        form.Open();
    }

    /// <summary>
    /// Открыть форму добавления вопросов 
    /// </summary>
    private void OpenAddQuestionsPanel(object sender, EventArgs e)
    {
        var form = _formFactory.Create<AddQuestionPanel>();
        form.Open();
    }

    /// <summary>
    /// Открыть форму добавления новой темы
    /// </summary>
    private void OpenAddThemePanel(object sender, EventArgs e)
    {
        var form = _formFactory.Create<AddNewTheme>();
        form.Open();
    }
    private void UpdateThemesButton(object sender, EventArgs e)
    {
        var form = _formFactory.Create<ThemeUpdate>();
        form.Open();
    }

    /// <summary>
    /// Закрытие формы
    /// </summary>
    private void FormClosingAction(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

}
