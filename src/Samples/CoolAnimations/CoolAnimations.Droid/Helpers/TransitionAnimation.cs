using System;
using Android.Transitions;

namespace CoolAnimations.Droid.Helpers
{
    //TRANSITION
    public class TransitionAnimation : TransitionSet
    {
        public TransitionAnimation()
        {
            this.SetOrdering(TransitionOrdering.Together);
            this.AddTransition(new ChangeBounds()).
                AddTransition(new ChangeTransform()).
                AddTransition(new ChangeImageTransform());
        }

        public static bool SupportTransitionAnimation()
        {
            return Android.OS.Build.VERSION.SdkInt > Android.OS.BuildVersionCodes.Lollipop;
        }
    }
}
