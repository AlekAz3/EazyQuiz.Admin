namespace EazyQuiz.Admin.Desktop;
public partial class AddNewTheme : Form
{
    private readonly ApiProvider _apiProvider;

    public AddNewTheme(ApiProvider apiProvider)
    {
        InitializeComponent();
        _apiProvider = apiProvider;
    }

    public void Open()
    {
        Show();
    }

    private async void button1_Click(object sender, EventArgs e)
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
