using EazyQuiz.Extensions;

namespace EazyQuiz.Admin.Desktop;

/// <summary>
/// Форма для входа
/// </summary>
public partial class LogIn : Form
{
    /// <inheritdoc cref="ApiProvider/>
    private readonly ApiProvider _apiProvider;

    /// <inheritdoc cref="CurrentUser"/>
    private readonly CurrentUser _user;

    /// <inheritdoc cref="IFormFactory/>
    private readonly IFormFactory _formFactory;

    public LogIn(ApiProvider apiProvider, CurrentUser user, IFormFactory formFactory)
    {
        _apiProvider = apiProvider;
        _user = user;
        _formFactory = formFactory;
        InitializeComponent();
    }

    ///<summary>
    /// Открытие окна
    /// </summary>
    internal void Open()
    {
        if (!Application.OpenForms.OfType<LogIn>().Any())
        {
            Show();
        }
    }

    /// <summary>
    /// Действия при нажатии кнопки "Вход"
    /// </summary>
    private async void EnterButtonClick(object sender, EventArgs e)
    {
        string username = UsernameInput.Text;
        string password = PasswordInput.Text;

        if (username.IsNullOrEmpty() || username.IsNullOrEmpty())
        {
            MessageBox.Show("Есть пустые поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        _user.SetUser(await _apiProvider.Authtenticate(username, password));

        if (_user.IsNull())
        {
            MessageBox.Show("Пользователь не найден или у вас нет прав администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        _formFactory.Create<MainPanel>().Open();
        Hide();
    }

    /// <summary>
    /// Действия при нажатии кнопки "Регистрация"
    /// </summary>
    private void RegistrationButtonClick(object sender, EventArgs e)
    {
        _formFactory.Create<Registration>().Open();
    }
}
