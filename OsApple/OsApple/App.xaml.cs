using OneSignalSDK.Xamarin;
using Xamarin.Forms;

namespace OsApple
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();

            OneSignal.Default.Initialize("3f188f7a-1797-4bae-ae43-20f9ff230e7e");
            OneSignal.Default.PromptForPushNotificationsWithUserResponse();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
