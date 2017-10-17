using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainerApp.Models;
using TrainerApp.ViewModels;

namespace TrainerApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return RedirectToAction("Login");
		}

		public ActionResult WorkOutEntry()
		{
			return View(new ViewModels.Lift());
		}

		public ActionResult Login()
		{
			return View();
		}

		public ActionResult LoginUser(ViewModels.Login model)
		{
			var trainerDB = new TrainerApp.Models.DataClasses1DataContext();

			var realUser = trainerDB.Users
							.FirstOrDefault(o => o.Username == model.Username
							&& o.Password == model.Password);

			if(realUser != null)
				return RedirectToAction("MaxLift", "Home", new { username = model.Username });
			else
				return RedirectToAction("LoginFail");
		}

		public ActionResult LoginSuccess()
		{
			return View();
		}

		public ActionResult LoginFail()
		{
			return View();
		}

		public ActionResult TestDB()
		{
			var trainerDB = new TrainerApp.Models.DataClasses1DataContext();
			var liftsList = new List<Models.Lift>();

			var lifts = from w in trainerDB.Lifts
						select w;

			if (lifts != null)
				liftsList = lifts.ToList();

			return View(liftsList);
		}

		public ActionResult MaxLift(string username)
		{
			var trainerDB = new TrainerApp.Models.DataClasses1DataContext();

			var maxLiftList = new List<vwMax>();

			var maxLift = trainerDB.vwMaxes.Where(o => o.username == username);

			if (maxLift != null)
				maxLiftList = maxLift.ToList();

			return View(maxLiftList);
		}

	}
}