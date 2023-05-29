using EazyQuiz.Cryptography;
using EazyQuiz.Models.DTO;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace EazyQuiz.Admin.Desktop;

/// <summary>
/// Работа с Апи EazyQuiz
/// </summary>
public class ApiProvider : IDisposable
{
    /// <inheritdoc cref="IConfiguration"/>
    private readonly IConfiguration _config;

    /// <inheritdoc cref="CurrentUser"/>
    private readonly CurrentUser _user;

    /// <inheritdoc cref="HttpClient"/>
    private readonly HttpClient _client;

    /// <summary>
    /// Адрес сервера 
    /// </summary>
    private readonly string? _baseAdress;

    public ApiProvider(IConfiguration config, CurrentUser user)
    {
        _config = config;
        _user = user;
        _baseAdress = _config["EazyQuizApiUrl"];
        _client = new HttpClient();
    }

    /// <summary>
    /// Авторизация пользователя 
    /// </summary>
    /// <param name="username">Ник</param>
    /// <param name="password">Пароль</param>
    /// <exception cref="ArgumentException">Пользователь не найден</exception>
    public async Task<UserResponse?> Authtenticate(string username, string password)
    {
        var salt = await GetUserSaltByUsername(username);

        if (string.IsNullOrEmpty(salt))
        {
            return null;
        }

        var hashPassword = PasswordHash.HashWithCurrentSalt(password, salt);

        var userAuth = new UserAuth()
        {
            Username = username,
            PasswordHash = hashPassword
        };

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"{_baseAdress}/api/Auth?Username={userAuth.Username}&PasswordHash={userAuth.PasswordHash}"),
        };

        var response = await _client.SendAsync(request);

        var responseBody = await response.Content.ReadAsStringAsync();

        var userResponse = JsonSerializer.Deserialize<UserResponse>(responseBody) ?? null;

        return userResponse;
    }

    /// <summary>
    /// Получение соли по нику игрока
    /// </summary>
    /// <param name="userName">Ник</param>
    /// <returns>Соль</returns>
    /// <exception cref="Exception">Соль не найдена</exception>
    public async Task<string> GetUserSaltByUsername(string userName)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"{_baseAdress}/api/Auth/{userName}"),
        };

        var response = await _client.SendAsync(request);

        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return "";
        }
        var responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }

    /// <summary>
    /// Регистрация нового игрока
    /// </summary>
    /// <param name="password">Пароль</param>
    /// <param name="username">Ник</param>
    /// <param name="country">Страна</param>
    internal async Task Registrate(string password, string username, string country)
    {
        var user = new UserRegister()
        {
            Username = username,
            Country = country,
            Password = PasswordHash.Hash(password),
            Role = "Admin"
        };

        string json = JsonSerializer.Serialize(user);

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri($"{_baseAdress}/api/Auth"),
            Content = new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json),
        };

        await _client.SendAsync(request);
    }

    /// <summary>
    /// Проверка на существующей ник 
    /// </summary>
    /// <param name="userName">Ник</param>
    /// <returns>true - если ник НЕ уникален</returns>
    /// <exception cref="ArgumentNullException">Нулл</exception>
    public async Task<bool> CheckUsername(string userName)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"{_baseAdress}/api/Auth/{userName}"),
        };

        var response = await _client.SendAsync(request);
        return response.StatusCode != System.Net.HttpStatusCode.NotFound;
    }

    /// <summary>
    /// Отправить на сервер новый вопрос
    /// </summary>
    /// <param name="quws">Вопрос в <see cref="QuestionInputDTO"/></param>
    public async Task SendNewQuestion(QuestionInputDTO quws)
    {
        string json = JsonSerializer.Serialize(quws);

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri($"{_baseAdress}/api/Questions/Add"),
            Content = new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json),
        };
        request.Headers.TryAddWithoutValidation("Accept", "application/json");
        request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {_user.GetToken()}");

        var response = await _client.SendAsync(request);
    }

    public void Dispose()
    {
        _client.Dispose();
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Получить список предложенных вопросов от пользователей
    /// </summary>
    /// <param name="filter">Фильтр</param>
    /// <returns>Коллекцию вопросов в <see cref="UserQuestionResponse"/></returns>
    public async Task<List<UserQuestionResponse>> GetUsersQuestionsByFilter(UserQuestionFilter filter)
    {
        var query = new Dictionary<string, string?>
        {
            ["Status"] = filter.Status,
        };

        string uri = QueryHelpers.AddQueryString($"{_baseAdress}/api/ManageUserQuestions", query);
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(uri),
        };
        request.Headers.TryAddWithoutValidation("Accept", "application/json");
        request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {_user.GetToken()}");

        var response = await _client.SendAsync(request);

        return await response.Content.ReadFromJsonAsync<List<UserQuestionResponse>>() ?? new List<UserQuestionResponse>();
    }

    /// <summary>
    /// Обновить статус пользовательского вопроса 
    /// </summary>
    /// <param name="userQuestionResponse">Вопрос с обновлённым статусом</param>
    public async Task UpdateUsersQuestionStatus(UserQuestionResponse userQuestionResponse)
    {
        string json = JsonSerializer.Serialize(userQuestionResponse);

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Put,
            RequestUri = new Uri($"{_baseAdress}/api/ManageUserQuestions"),
            Content = new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json),
        };
        request.Headers.TryAddWithoutValidation("Accept", "application/json");
        request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {_user.GetToken()}");

        var response = await _client.SendAsync(request);
    }

    public async Task SendNewTheme(string text)
    {
        string json = JsonSerializer.Serialize(text);

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri($"{_baseAdress}/api/Themes"),
            Content = new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json),
        };
        request.Headers.TryAddWithoutValidation("Accept", "application/json");
        request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {_user.GetToken()}");

        var response = await _client.SendAsync(request);
    }

    internal async Task<IReadOnlyCollection<ThemeResponseWithFlag>> GetThemes()
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"{_baseAdress}/api/Themes/all"),
        };
        request.Headers.TryAddWithoutValidation("Accept", "application/json");
        request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {_user.GetToken()}");

        var response = await _client.SendAsync(request);

        return await response.Content.ReadFromJsonAsync<List<ThemeResponseWithFlag>>() ?? new List<ThemeResponseWithFlag>();

    }

    public async Task UpdateThemes(IReadOnlyCollection<ThemeResponseWithFlag> themes)
    {
        string json = JsonSerializer.Serialize(themes);

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Put,
            RequestUri = new Uri($"{_baseAdress}/api/Themes"),
            Content = new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json),
        };
        request.Headers.TryAddWithoutValidation("Accept", "application/json");
        request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {_user.GetToken()}");

        var response = await _client.SendAsync(request);
    }

    internal async Task<IReadOnlyCollection<FeedbackResponse>> GetFeedbacks(string status)
    {

        var query = new Dictionary<string, string?>
        {
            ["status"] = status
        };
        string uri = QueryHelpers.AddQueryString($"{_baseAdress}/api/Feedback", query);

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(uri),
        };
        request.Headers.TryAddWithoutValidation("Accept", "application/json");
        request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {_user.GetToken()}");

        var response = await _client.SendAsync(request);

        return await response.Content.ReadFromJsonAsync<List<FeedbackResponse>>() ?? new List<FeedbackResponse>();

    }

    internal async Task UpdateFeedbackStatus(FeedbackUpdateDTO updatedFeedback)
    {
        string json = JsonSerializer.Serialize(updatedFeedback);

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Put,
            RequestUri = new Uri($"{_baseAdress}/api/Feedback"),
            Content = new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json),
        };
        request.Headers.TryAddWithoutValidation("Accept", "application/json");
        request.Headers.TryAddWithoutValidation("Authorization", $"Bearer {_user.GetToken()}");

        var response = await _client.SendAsync(request);
    }
}
