using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TrainerApp.ViewModels
{
	public class User : ModelBase
	{
		[Display(Name ="Username:")]
		public string Username { get; set; } = "";

		[Display(Name = "First Name:")]
		public string FirstName { get; set; } = "";

		[Display(Name = "Last Name:")]
		public string LastName { get; set; } = "";

		[Display(Name = "Address:")]
		public string Address { get; set; } = "";

		[Display(Name = "City:")]
		public string City { get; set; } = "";

		[Display(Name = "State:")]
		public string State { get; set; } = "";

		[Display(Name = "Zip Code:")]
		[DataType(DataType.PostalCode)]
		public string PostalZipCode { get; set; } = "";

		[Display(Name = "Country:")]
		public string Country { get; set; } = "United States";

		[Display(Name = "Phone Number:")]
		[DataType(DataType.PhoneNumber)]
		public string PhoneNumber { get; set; } = "";

		[Display(Name = "Email:")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; } = "";

		public int ProgramID { get; set; }

		public bool IsActive { get; set; }

		public User()
		{

		}
	}
}