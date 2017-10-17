using System.ComponentModel.DataAnnotations;

namespace TrainerApp.ViewModels
{
	public class Login
	{
		[Required]
		[Display(Name ="Username:")]
		public string Username { get; set; } = "";

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Password:")]
		public string Password { get; set; } = "";

		public Login()
		{

		}
	}
}