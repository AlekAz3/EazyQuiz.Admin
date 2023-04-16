using EazyQuiz.Admin.Desktop;
using EazyQuiz.Extensions;

namespace EazyQuiz.Admin.Desktop;

public partial class LogIn : Form
{
    /// <inheritdoc cref="ApiProvider/>
    private readonly ApiProvider _apiProvider;

    /// <inheritdoc cref="UserToken/>
    private readonly UserToken _userToken;

    /// <inheritdoc cref="IFormFactory/>
    private readonly IFormFactory _formFactory;

    public LogIn(ApiProvider apiProvider, UserToken userToken, IFormFactory formFactory)
    {
        _apiProvider = apiProvider;
        _userToken = userToken;
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

        _userToken.User = await _apiProvider.Authtenticate(username, password);
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
