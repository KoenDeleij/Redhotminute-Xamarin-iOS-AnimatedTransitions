using Android.App;
using Android.OS;
using CoolAnimations.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace CoolAnimations.Droid.Views
{
    [Activity]
    public class CenterPointRevealActivity : MvxAppCompatActivity<CenterPointRevealViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CenterPointRevealView);
        }
    }
}
