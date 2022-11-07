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

            OneSignal.Default.Initialize("Your OneSignal App ID");
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
