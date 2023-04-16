

namespace EazyQuiz.Admin.Desktop;
public partial class MainPanel : Form
{
    private readonly IFormFactory _formFactory;

    public MainPanel(IFormFactory formFactory)
    {
        InitializeComponent();
        _formFactory = formFactory;
    }

    public void Open()
    {
        Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var form = _formFactory.Create<ManageUsersQuestionPanel>();
        form.Open();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var form = _formFactory.Create<AddQuestionPanel>();
        form.Open();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        var form = _formFactory.Create<AddNewTheme>();
        form.Open();
    }

    private void MainPanel_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
