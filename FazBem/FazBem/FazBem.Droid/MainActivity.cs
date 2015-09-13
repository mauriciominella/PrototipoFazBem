using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace FazBem.Droid
{
    [Activity(Label = "FazBem", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

			SetStatusBarColor ();

            LoadApplication(new App());
        }

		void SetStatusBarColor ()
		{
			if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Lollipop) {
				Window.AddFlags (WindowManagerFlags.DrawsSystemBarBackgrounds);
				Window.SetStatusBarColor (Resources.GetColor (Resource.Color.StatusBarColor));
			}
		}
    }
}

