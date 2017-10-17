
namespace TrainerApp.ViewModels
{
	public class ModelBase
	{
		public const int NEWID = -1;

		public int ID { get; set; }

		public ModelBase()
		{
			ID = NEWID;
		}
	}
}