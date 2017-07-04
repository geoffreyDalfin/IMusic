using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IMusic.Views
{
	public partial class MainPage : ContentPage
	{
		RootPage root;
		List<HomeMenuItem> menuItems;
		public MainPage(RootPage root)
		{
			this.root = root;
			InitializeComponent();
			ListViewMenu.BackgroundColor = Color.FromHex("#03A9F4");

			ListViewMenu.ItemsSource = menuItems = new List<HomeMenuItem>
				{
					new HomeMenuItem { Title = "Home", MenuType = MenuType.Home, Icon ="Home.png" },
					new HomeMenuItem { Title = "Blog", MenuType = MenuType.Blog, Icon = "Home.png" },
					new HomeMenuItem { Title = "Twitter", MenuType = MenuType.Twitter, Icon = "Home.png" },
					new HomeMenuItem { Title = "Hanselminutes", MenuType = MenuType.Hanselminutes, Icon="Home.png" },
					new HomeMenuItem { Title = "Ratchet", MenuType = MenuType.Ratchet, Icon = "Home.png" },
					new HomeMenuItem { Title = "Developers Life", MenuType = MenuType.DeveloperLife, Icon = "Home.png"},
					new HomeMenuItem { Title = "Channel9 Videos", MenuType = MenuType.Videos, Icon = "Home.png"},

				};

			ListViewMenu.SelectedItem = menuItems[0];

			ListViewMenu.ItemSelected += async (sender, e) =>
				{
					if (ListViewMenu.SelectedItem == null)
						return;

					await this.root.NavigateAsync(((HomeMenuItem)e.SelectedItem).MenuType);
				};
		}

	}
}
