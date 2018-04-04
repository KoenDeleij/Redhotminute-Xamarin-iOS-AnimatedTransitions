using System.Collections.Generic;
using Android.App;
using Android.OS;
using CoolAnimations.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Presenters;
using MvvmCross.Presenters.Attributes;
using MvvmCross.ViewModels;

namespace CoolAnimations.Droid.Views
{
    [Activity]
    public class HomeActivity : MvxAppCompatActivity<HomeViewModel>, IMvxOverridePresentationAttribute
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HomeView);
        }

        public MvxBasePresentationAttribute PresentationAttribute(MvxViewModelRequest request)
        {
            MvxActivityPresentationAttribute attr = new MvxActivityPresentationAttribute();
            //attr.SharedElements = new Dictionary<string, Android.Views.View>();

            return attr;
        }
    }
}
