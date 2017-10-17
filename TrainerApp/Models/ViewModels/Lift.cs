using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TrainerApp.ViewModels
{
	public class Lift : ModelBase
	{
		[Required]
		[Display(Name = "Lift Name:")]
		[UIHint("RadioButtonList")]
		public LiftType Type { get; set; } = LiftType.None;

		/// <summary>
		/// Number of reps in each set
		/// </summary>
		[Required]
		[Display(Name = "Reps:")]
		public int Reps { get; set; } = 0;

		/// <summary>
		/// Number of Sets completed during the work out.
		/// </summary>
		[Required]
		[Display(Name = "Sets:")]
		public int Sets { get; set; } = 0;

		/// <summary>
		/// Number of the weight that was used for each Rep.
		/// </summary>
		[Required]
		[Display(Name = "Weight:")]
		public int Weight { get; set; } = 0;

		public Lift()
		{ 
		}
	}
}