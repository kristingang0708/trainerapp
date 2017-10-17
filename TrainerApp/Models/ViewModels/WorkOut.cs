using System;
using System.Collections.Generic;

namespace TrainerApp.ViewModels
{
	public class WorkOut : ModelBase
	{
		/// <summary>
		/// Type of Lift that was performed during this work out.
		/// </summary>
		public List<Lift> Lifts { get; set; } = new List<Lift>();

		/// <summary>
		/// User that performed the work out.
		/// </summary>
		public User User { get; set; } = new User();

		/// <summary>
		/// Date the work out was performed.
		/// </summary>
		public DateTime WorkOutDate { get; set; } = DateTime.UtcNow;

		public WorkOut()
		{

		}
	}
}