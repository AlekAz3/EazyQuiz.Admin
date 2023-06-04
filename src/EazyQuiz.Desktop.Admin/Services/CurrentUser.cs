using EazyQuiz.Models.DTO;

namespace EazyQuiz.Admin.Desktop;

/// <summary>
/// Сервис о текущем пользователе программы
/// </summary>
public class CurrentUser
{
    /// <summary>
    /// Информация об авторизованном пользователе
    /// </summary>
    private UserResponse? User { get; set; }

    /// <summary>
    /// Установить пользователя программы
    /// </summary>
    /// <param name="user"></param>
    public void SetUser(UserResponse? user)
    {
        User = user;
    }

    /// <summary>
    /// Есть ли пользователь
    /// </summary>
    /// <returns>true - нет пользователя</returns>
    public bool IsNull()
    {
        return User == null;
    }

    /// <summary>
    /// Получить JWT токен пользователя
    /// </summary>
    /// <returns>JWT токен</returns>
    public string GetToken()
    {
        return User.Token.Jwt;
    }
}
