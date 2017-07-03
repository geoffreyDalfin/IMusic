using System;
namespace IMusic
{
	public enum MenuType
	{
		About,
		Blog,
		Twitter,
		Hanselminutes,
		Ratchet,
		DeveloperLife,
		Videos
	}

	public class HomeMenuItem
	{

		public HomeMenuItem()
		{
			MenuType = MenuType.About;
		}
		public string Title { get; set; }
		public string Icon { get; set; }
		public MenuType MenuType { get; set; }

	}
}
