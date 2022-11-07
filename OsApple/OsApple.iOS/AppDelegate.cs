using Foundation;
using OneSignalSDK.Xamarin;
using UIKit;

namespace OsApple.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            OneSignal.Default.Initialize("3f188f7a-1797-4bae-ae43-20f9ff230e7e");
            OneSignal.Default.PromptForPushNotificationsWithUserResponse();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
