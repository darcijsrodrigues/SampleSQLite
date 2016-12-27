using UIKit;
using Foundation;
using Xamarin.Forms;

namespace SampleSQLite.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			// affects all UISwitch controls in the app
			UISwitch.Appearance.OnTintColor = UIColor.FromRGB(0x91, 0xCA, 0x47);
			LoadApplication(new App());

			//Forms.Init();
			return base.FinishedLaunching(app, options);
		}
	}
}
