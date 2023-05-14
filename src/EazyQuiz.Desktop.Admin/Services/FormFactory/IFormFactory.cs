namespace EazyQuiz.Admin.Desktop;

/// <summary>
/// Интерфейс фабрика по создаю форм
/// </summary>
public interface IFormFactory
{
    /// <summary>
    /// Создание экземпляра класса наследника от <see cref="Form"/>
    /// </summary>
    T Create<T>() where T : Form;
}
