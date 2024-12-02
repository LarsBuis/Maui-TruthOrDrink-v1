using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace MauiApp2
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#27233A"));
                Window.SetNavigationBarColor(Android.Graphics.Color.ParseColor("#9966FF"));
            }
            // Hide the navigation bar but keep the status bar visible
            Window.DecorView.SystemUiVisibility = (StatusBarVisibility)(
                SystemUiFlags.LayoutStable | // Ensures layout remains stable when toggling UI flags
                SystemUiFlags.HideNavigation); // Hides navigation bar
        }
    }
}
