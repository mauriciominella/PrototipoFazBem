using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XLabs.Ioc;
using XLabs.Platform.Device;
using XLabs.Platform.Services;
using FazBem.Repositories;
using FazBem.Interfaces;
using FazBem.Droid.Implementations;

namespace FazBem.Droid
{
    [Activity(Label = "FazBem", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            #region Resolver Init

            SimpleContainer container = new SimpleContainer();
            container.Register<IDevice>(t => AndroidDevice.CurrentDevice);
            container.Register<IDisplay>(t => t.Resolve<IDevice>().Display);
            container.Register<INetwork>(t => t.Resolve<IDevice>().Network);
            container.Register<ISQLite>(typeof(SQLiteAndroid));

            Resolver.SetResolver(container.GetResolver()); 
            #endregion

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

