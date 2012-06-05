using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PaintCode
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}

	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		UIViewController news;		

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			news = new NewsDialogViewController();
			news.View.AutoresizingMask = UIViewAutoresizing.All;
			news.View.Frame = new System.Drawing.RectangleF(0
						, UIApplication.SharedApplication.StatusBarFrame.Height
						, UIScreen.MainScreen.ApplicationFrame.Width
						, UIScreen.MainScreen.ApplicationFrame.Height);

			// If you have defined a view, add it here:
			window.AddSubview (news.View);
			
			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

