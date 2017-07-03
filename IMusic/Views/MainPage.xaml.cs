﻿using System;
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
			ListViewMenu.BackgroundColor = Color.FromHex("#F5F5F5");

			ListViewMenu.ItemsSource = menuItems = new List<HomeMenuItem>
				{
					new HomeMenuItem { Title = "About", MenuType = MenuType.About, Icon ="about.png" },
					new HomeMenuItem { Title = "Blog", MenuType = MenuType.Blog, Icon = "blog.png" },
					new HomeMenuItem { Title = "Twitter", MenuType = MenuType.Twitter, Icon = "twitternav.png" },
					new HomeMenuItem { Title = "Hanselminutes", MenuType = MenuType.Hanselminutes, Icon = "hm.png" },
					new HomeMenuItem { Title = "Ratchet", MenuType = MenuType.Ratchet, Icon = "ratchet.png" },
					new HomeMenuItem { Title = "Developers Life", MenuType = MenuType.DeveloperLife, Icon = "tdl.png"},
					new HomeMenuItem { Title = "Channel9 Videos", MenuType = MenuType.Videos, Icon = "channel9.png"},

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