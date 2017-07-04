using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using IMusic.iOS.Renderers;
using System.Collections.Generic;
using UIKit;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationRenderer))]
namespace IMusic.iOS.Renderers
{
public class CustomNavigationRenderer : NavigationRenderer
{

	public override void PushViewController(UIKit.UIViewController viewController, bool animated)
	{
		base.PushViewController(viewController, animated);

		var list = new List<UIBarButtonItem>();

		foreach (var item in TopViewController.NavigationItem.RightBarButtonItems)
		{
			if (string.IsNullOrEmpty(item.Title))
			{
				continue;
			}

			if (item.Title.ToLower() == "add")
			{
				var newItem = new UIBarButtonItem(UIBarButtonSystemItem.Add)
				{
					Action = item.Action,
					Target = item.Target
				};

				list.Add(newItem);
			}

			TopViewController.NavigationItem.RightBarButtonItems = list.ToArray();
		}
	}

}
}