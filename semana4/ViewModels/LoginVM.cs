using System.ComponentModel.DataAnnotations;

namespace semana4.ViewModels;

public class LoginVM
{
	[Required(ErrorMessage = "Se requiere nombre de usuario")]
	public string? Username { get; set; }

	[Required(ErrorMessage = "Se requiere contraseña")]
	[DataType(DataType.Password)]
	public string? Password { get; set; }

	[Display(Name = "Recordarme")]
	public bool RememberMe { get; set; }
}