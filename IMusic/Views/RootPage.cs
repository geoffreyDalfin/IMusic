using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMusic.Views
{
	public class RootPage : MasterDetailPage
	{
		Dictionary<MenuType, NavigationPage> Pages { get; set; }
		public RootPage()
		{
			Pages = new Dictionary<MenuType, NavigationPage>();
			Master = new MainPage(this);
			NavigateAsync(MenuType.About);


			InvalidateMeasure();

		}

		public async Task NavigateAsync(MenuType id)
		{
			if (Detail != null)
			{
				if (Device.RuntimePlatform == Device.Android)
					await Task.Delay(300);
			}

			Page newPage;
			if (!Pages.ContainsKey(id))
			{
				switch (id)
				{
				/*	case MenuType.About:
						Pages.Add(id, new NavigationPage(new AboutPage()));
						break;
					case MenuType.Blog:
						Pages.Add(id, new NavigationPage(new BlogPage()));
						break;
					case MenuType.DeveloperLife:
						Pages.Add(id, new NavigationPage(new PodcastPage(id)));
						break;
					case MenuType.Hanselminutes:
						Pages.Add(id, new NavigationPage(new PodcastPage(id)));
						break;
					case MenuType.Ratchet:
						Pages.Add(id, new NavigationPage(new PodcastPage(id)));
						break;
					case MenuType.Twitter:
						Pages.Add(id, new NavigationPage(new TwitterPage()));
						break;
					case MenuType.Videos:
						Pages.Add(id, new NavigationPage(new Channel9VideosPage()));
						break;*/
				}
			}
			newPage = Pages[id];
			if (newPage == null)
				return;
			Detail = newPage;



		}
	}
}
