using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppLifecycleTutorial
{
    public partial class App : Application
    {
        const string displayText = "displayText";

        public string DisplayText { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Console.WriteLine("OnStart");
            if (Properties.ContainsKey(displayText))
            {
                DisplayText = (string)Properties[displayText];
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Console.WriteLine("OnSleep");
            Properties[displayText] = DisplayText;
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Console.WriteLine("OnResume");
        }
    }
}
