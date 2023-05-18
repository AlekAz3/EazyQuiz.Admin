using Microsoft.Extensions.DependencyInjection;

namespace EazyQuiz.Admin.Desktop;

/// <summary>
/// Реализация <inheritdoc cref="IFormFactory"/>
/// </summary>
public class FormFactory : IFormFactory
{
    /// <inheritdoc cref="IServiceScope"/>
    private readonly IServiceScope _scope;

    public FormFactory(IServiceScopeFactory scopeFactory)
    {
        _scope = scopeFactory.CreateScope();
    }

    public T Create<T>() where T : Form
    {
        return _scope.ServiceProvider.GetRequiredService<T>();
    }
}
