using EazyQuiz.Models.DTO;

namespace EazyQuiz.Desktop.Admin;

public partial class ManageUsersQuestionPanel : Form
{
    private readonly UserToken _user;
    private readonly ApiProvider _apiProvider;

    private List<UserQuestionResponse> list { get; set; }

    public ManageUsersQuestionPanel(UserToken user, ApiProvider apiProvider)
    {
        InitializeComponent();
        _user = user;
        _apiProvider = apiProvider;
    }

    /// <summary>
    /// Открыть окно
    /// </summary>
    public void Open()
    {
        Show();
    }

    private async void ManageUsersQuestionPanelLoad(object sender, EventArgs e)
    {
        list = await _apiProvider.GetUsersQuestionsByFilter(new UserQuestionFilter() { Status = "Новый" }, _user.User.Token ?? "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6ImI5MWU1MGMwLWMxZWYtNDg2MS1hNmYzLWFkYzg2NDdhNGU2OCIsImV4cCI6MTY4MDgwNjA1MiwiaXNzIjoiU2VydmVyIiwiYXVkIjoiVW5pdHkifQ.NSHT8Qd0We_cgdpVur8X-Tv1jZRI6DrBzUTnZnijv4VUi_zESbPYIeD9XwSeJ7-VpjVvld9HyZFmedTj4S74FQ");
        listBox1.DisplayMember = nameof(UserQuestionResponse.QuestionText);
        listBox1.ValueMember = nameof(UserQuestionResponse.Id);
        listBox1.DataSource = list;
    }

    private void listBox1_SelectedValueChanged(object sender, EventArgs e)
    {
        var a = (UserQuestionResponse)listBox1.SelectedItem;
    }
}
