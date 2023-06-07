using EazyQuiz.Models.DTO;

namespace EazyQuiz.Admin.Desktop;
public partial class UsersFeedback : Form
{
    private readonly ApiProvider _apiProvider;

    private List<FeedbackResponse> Feedbacks { get; set; } = new List<FeedbackResponse>();

    public UsersFeedback(ApiProvider apiProvider)
    {
        InitializeComponent();
        _apiProvider = apiProvider;
        FeedbackStatus.SelectedIndex = 0;
        StatusShow.SelectedIndex = 0;
        ListFeedbacks.DisplayMember = nameof(FeedbackResponse.Text);
        ListFeedbacks.ValueMember = nameof(FeedbackResponse.Id);
    }

    public void Open()
    {
        Show();
    }

    private async void LoadFeedbacks(object sender, EventArgs e)
    {
       
    }

    private async Task RefreshFeedbackList()
    {
        ListFeedbacks.Items.Clear();
        var status = StatusShow.Text.Trim();

        Feedbacks = (await _apiProvider.GetFeedbacks(status)).ToList();

        foreach (var feedback in Feedbacks)
        {
            ListFeedbacks.Items.Add(feedback);
        }
    }

    private void ChangeSelectedIndex(object sender, EventArgs e)
    {
        var feedback = ListFeedbacks.SelectedItem as FeedbackResponse;

        FeedbackEmail.Text = feedback.Email;
        FeedbackText.Text = feedback.Text;

        switch (feedback.Status)
        {
            case "Новый":
                FeedbackStatus.SelectedIndex = 0;
                break;
            case "В работе":
                FeedbackStatus.SelectedIndex = 1;
                break;
            case "Ответ отправлен на почту":
                FeedbackStatus.SelectedIndex = 2;
                break;
            case "Закрыто":
                FeedbackStatus.SelectedIndex = 3;
                break;
            default:
                break;
        }
    }

    private async void SaveStateButtonClick(object sender, EventArgs e)
    {
        var feedback = ListFeedbacks.SelectedItem as FeedbackResponse;
        string status = (string)FeedbackStatus.SelectedItem;

        var updatedFeedback = new FeedbackUpdateDTO()
        {
            Id = feedback.Id,
            Status = status
        };
        await _apiProvider.UpdateFeedbackStatus(updatedFeedback);
        await RefreshFeedbackList();
    }

    private async void ChangeList(object sender, EventArgs e)
    {
        await RefreshFeedbackList();
    }
}
