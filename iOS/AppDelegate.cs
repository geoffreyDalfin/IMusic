using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using Plugin.MediaManager.Forms.iOS;
using RoundedBoxView.Forms.Plugin.iOSUnified;
using UIKit;

namespace IMusic.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			RoundedBoxViewRenderer.Init();
            ImageCircleRenderer.Init();
			VideoViewRenderer.Init();
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
