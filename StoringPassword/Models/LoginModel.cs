using System.ComponentModel.DataAnnotations;

namespace StoringPassword.Models;

// Клас моделі-подання (view-model)
public class LoginModel
{
    [Required(ErrorMessage = "Введіть логін")]
    public string? Login { get; set; }

    [Required(ErrorMessage = "Введіть пароль")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}