using EazyQuiz.Models.DTO;

namespace EazyQuiz.Admin.Desktop;

/// <summary>
/// Форма управления вопросами предложенных пользователями
/// </summary>
public partial class ManageUsersQuestionPanel : Form
{
    /// <inheritdoc cref="ApiProvider"/>
    private readonly ApiProvider _apiProvider;

    /// <inheritdoc cref="IFormFactory"/>
    private readonly IFormFactory _formFactory;

    /// <summary>
    /// Список предложенных пользователями ответов
    /// </summary>
    private List<UserQuestionResponse>? UsersQuestions { get; set; }

    public ManageUsersQuestionPanel(ApiProvider apiProvider, IFormFactory formFactory)
    {
        InitializeComponent();
        _apiProvider = apiProvider;
        _formFactory = formFactory;
    }

    /// <summary>
    /// Открыть окно
    /// </summary>
    public void Open()
    {
        Show();
        Task.Run(RefreshList);
    }

    /// <summary>
    /// Загрузка формы 
    /// </summary>
    private async void FormLoadEvent(object sender, EventArgs e)
    {
        await RefreshList();
        if (usersQuestionsList.Items.Count > 0)
        {
            usersQuestionsList.SelectedIndex = 0;

        }
    }

    /// <summary>
    /// Переключение между вопросами
    /// </summary>
    private void SelectUserQuestion(object sender, EventArgs e)
    {
        var selectedQuestion = (UserQuestionResponse)usersQuestionsList.SelectedItem!;

        if (selectedQuestion is null)
        {
            return;
        }
        questionTextLabel.Text = selectedQuestion.QuestionText;
        answerTextLabel.Text = selectedQuestion.AnswerText;
    }

    /// <summary>
    /// Обновить список вопросов 
    /// </summary>
    private async Task RefreshList()
    {
        UsersQuestions = await _apiProvider.GetUsersQuestionsByFilter(new UserQuestionFilter() { Status = "Новый" });

        usersQuestionsList.Items.Clear();
        usersQuestionsList.DisplayMember = nameof(UserQuestionResponse.QuestionText);
        usersQuestionsList.ValueMember = nameof(UserQuestionResponse.Id);
        foreach (var item in UsersQuestions)
        {
            usersQuestionsList.Items.Add(item);
        }
    }

    /// <summary>
    /// Предложенный вопрос принят
    /// </summary>
    private void AcceptQuestionClick(object sender, EventArgs e)
    {
        var selectedQuestion = (UserQuestionResponse)usersQuestionsList.SelectedItem!;
        if (selectedQuestion is null)
        {
            return;
        }

        selectedQuestion.Status = "Принято";

        var a = _formFactory.Create<AddQuestionPanel>();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        a.FormClosing += FormLoadEvent;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        a.ShowWithUsersQuestion(selectedQuestion);
    }

    /// <summary>
    /// Предложенный вопрос не принят
    /// </summary>
    private async void DenyQuestionClick(object sender, EventArgs e)
    {
        var choice = MessageBox.Show("Вы уверены?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        var selectedQuestion = (UserQuestionResponse)usersQuestionsList.SelectedItem!;

        if (selectedQuestion is null)
        {
            return;
        }
        if (choice == DialogResult.Yes)
        {
            selectedQuestion.Status = "Отклонено";
            await _apiProvider.UpdateUsersQuestionStatus(selectedQuestion);
        }
        await RefreshList();
    }

    /// <summary>
    /// Кнопка обновления списка вопросов от пользователей  
    /// </summary>
    private async void RefreshListClick(object sender, EventArgs e)
    {
        await RefreshList();
    }

    /// <summary>
    /// Кнопка возвращение к форме добавления вопроса
    /// </summary>
    private void ExitButtonClick(object sender, EventArgs e)
    {
        Close();
    }
}
