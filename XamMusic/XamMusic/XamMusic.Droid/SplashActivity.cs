
using Android.App;
using Android.Content;
using Android.OS;
using DLToolkit.Forms.Controls;
using FFImageLoading.Forms.Platform;
using Plugin.CurrentActivity;

namespace XamMusic.Droid
{
    [Activity(Label = "Xam Music", MainLauncher = true, NoHistory = true, Theme = "@style/Theme.Splash")]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // FFImageLoading
            CachedImageRenderer.Init(true);

            CrossCurrentActivity.Current.Init(this, bundle);
            Rg.Plugins.Popup.Popup.Init(this);

            //// AudioService setup
            //AudioServiceIntent = new Intent(Droid.Audio.AudioService.ActionStart);
            //ComponentName name = StartService(AudioServiceIntent);
            //var _connection = new AudioServiceConnection(this);
            //bool binded = BindService(AudioServiceIntent, _connection, Bind.AutoCreate);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            // FlowListView
            FlowListView.Init();

            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }
    }
}