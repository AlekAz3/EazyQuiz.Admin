using EazyQuiz.Models.DTO;

namespace EazyQuiz.Admin.Desktop;

/// <summary>
/// Глобальный параметр 
/// </summary>
public class UserToken
{
    /// <summary>
    /// Инфа об авторизованном пользователе
    /// </summary>
    public UserResponse User { get; set; } = new UserResponse();
}
