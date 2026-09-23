using System.ComponentModel.DataAnnotations;

namespace StoringPassword.Models;

// Клас моделі-подання (view-model)

public class RegisterModel
{
    [Required(ErrorMessage = "Введіть ім'я")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "Введіть прізвище")]
    public string? LastName { get; set; }

    [Required(ErrorMessage = "Введіть логін")]
    public string? Login { get; set; }

    [Required(ErrorMessage = "Введіть пароль")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Підтвердіть пароль")]
    [Compare("Password", ErrorMessage = "Паролі не збігаються")]
    [DataType(DataType.Password)]
    public string? PasswordConfirm { get; set; }
}