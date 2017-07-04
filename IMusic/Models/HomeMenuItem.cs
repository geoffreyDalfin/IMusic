using System;
namespace IMusic
{
	public enum MenuType
	{
		Home,
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
			MenuType = MenuType.Home;
		}
		public string Title { get; set; }
		public string Icon { get; set; }
		public MenuType MenuType { get; set; }

	}
}
