using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EazyQuiz.Desktop.Admin;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var host = Host.CreateDefaultBuilder()
                     .ConfigureServices((context, services) =>
                     {
                         ConfigureServices(services);
                     })
                     .Build();

        var mainForm = host.Services.GetRequiredService<ManageUsersQuestionPanel>();
        Application.Run(mainForm);
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IFormFactory, FormFactory>();

        var forms = typeof(Program).Assembly
                .GetTypes()
                .Where(t => t.BaseType == typeof(Form))
                .ToList();

        forms.ForEach(form =>
        {
            services.AddTransient(form);
        });

        services.AddSingleton<ApiProvider>();
        services.AddSingleton<UserToken>();
    }
}
