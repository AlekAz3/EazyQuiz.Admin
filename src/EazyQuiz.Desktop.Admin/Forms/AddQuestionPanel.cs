using EazyQuiz.Extensions;
using EazyQuiz.Models.DTO;

namespace EazyQuiz.Admin.Desktop;

/// <summary>
/// Панель для добавления вопросов 
/// </summary>
public partial class AddQuestionPanel : Form
{
    /// <inheritdoc cref="ApiProvider"/>
    private readonly ApiProvider _apiProvider;

    /// <inheritdoc cref="IFormFactory"/>
    private readonly IFormFactory _formFactory;

    /// <inheritdoc cref="UserQuestionResponse"/>
    private UserQuestionResponse? UserQuestionSelected { get; set; }

    /// <summary>
    /// Коллекция тем 
    /// </summary>
    private IReadOnlyCollection<ThemeResponseWithFlag> Themes { get; set; } = new List<ThemeResponseWithFlag>();

    public AddQuestionPanel(ApiProvider apiProvider, IFormFactory formFactory)
    {
        _apiProvider = apiProvider;
        _formFactory = formFactory;
        InitializeComponent();
    }

    /// <summary>
    /// Открыть окно
    /// </summary>
    public async void Open()
    {
        Show();
        await RefrashThemes();
    }

    /// <summary>
    /// Отправить вопрос на сервер 
    /// </summary>
    private async void SendQuestionToServer(object sender, EventArgs e)
    {
        if (QuestionInput.Text.IsNullOrEmpty() || FirstAnswerInput.Text.IsNullOrEmpty() || SecondAnswerInput.Text.IsNullOrEmpty() || ThirdAnswerInput.Text.IsNullOrEmpty() || ForthAnswerInput.Text.IsNullOrEmpty())
        {
            MessageBox.Show("Есть пустое поле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var question = new QuestionInputDTO()
        {
            Text = QuestionInput.Text,
            ThemeId = ((ThemeResponseWithFlag)themesList.SelectedItem).Id,
            Answers = new List<AnswerInputDTO>()
            {
                new AnswerInputDTO()
                {
                    Text = FirstAnswerInput.Text,
                    IsCorrect = IsFirstAnswerCorrect.Checked
                },
                new AnswerInputDTO()
                {
                    Text = SecondAnswerInput.Text,
                    IsCorrect = IsSecondAnswerCorrect.Checked
                },
                new AnswerInputDTO()
                {
                    Text = ThirdAnswerInput.Text,
                    IsCorrect = IsThirdAnswerCorrect.Checked
                },
                new AnswerInputDTO()
                {
                    Text = ForthAnswerInput.Text,
                    IsCorrect = IsForthAnswerCorrect.Checked
                },
            }
        };

        if (UserQuestionSelected is not null)
        {
            UserQuestionSelected.Status = "Принято";
            await _apiProvider.UpdateUsersQuestionStatus(UserQuestionSelected);
        }

        await _apiProvider.SendNewQuestion(question);

        MessageBox.Show("Вопрос отправлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        foreach (Control c in Controls)
        {
            if (c is RichTextBox)
            {
                c.Text = string.Empty;
            }
        }
        if (UserQuestionSelected is not null)
        {
            Close();
        }
    }

    /// <summary>
    /// Открыть форму для добавления предложенного пользователем вопроса
    /// </summary>
    /// <param name="userQuestion">Предложенный пользователем вопрос</param>
    public async void ShowWithUsersQuestion(UserQuestionResponse userQuestion)
    {
        UserQuestionSelected = userQuestion;
        UsersQuestionButton.Hide();
        QuestionInput.Text = userQuestion.QuestionText;
        FirstAnswerInput.Text = userQuestion.AnswerText;
        IsFirstAnswerCorrect.Checked = true;
        await RefrashThemes();
        Show();
    }

    /// <summary>
    /// Обновить список тем для вопросов
    /// </summary>
    private async Task RefrashThemes()
    {
        Themes = await _apiProvider.GetThemes();
        themesList.Items.Clear();;
        foreach (var item in Themes)
        {
            themesList.Items.Add(item);
        }

        if (Themes.Count > 0)
        {
            themesList.SelectedIndex = 0;
        }
    }

    /// <summary>
    /// Переход к форме <see cref="ManageUsersQuestionPanel"/>
    /// </summary>
    private void ShowManageUserQuestion(object sender, EventArgs e)
    {
        _formFactory.Create<ManageUsersQuestionPanel>().Open();
        Close();
    }
}
