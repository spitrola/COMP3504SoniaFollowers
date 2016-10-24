using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Views.Animations;
using Android.Animation;

namespace UniBlu
{
    [Activity(Label = "BaseActivity")]
    public class BaseActivity : Activity
    {
        protected Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            FindViews();
            SetToolBar();
        }

        private void SetToolBar()
        {
            SetActionBar(toolbar);
        }

        private void FindViews()
        {
            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
        }

        protected override void OnResume()
        {
            base.OnResume();
            Music.play(this, Resource.Raw.pomp_loop);
        }
        protected override void OnPause()
        {
            base.OnPause();
            Music.stop(this);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.SettingsMenu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.settings:
                    var intent = new Intent(this, typeof(SettingsActivity));
                    StartActivity(intent);
                    return true;
                case Resource.Id.about:
                    intent = new Intent(this, typeof(AboutActivity));
                    StartActivity(intent);
                    return true;
                case Android.Resource.Id.Home:
                    Finish();
                    return true;
                default:
                    Animation myAnimation = AnimationUtils.LoadAnimation(this, Resource.Animation.screenShake);
                    toolbar.StartAnimation(myAnimation);
                    Toast toast = Toast.MakeText(this, Resource.String.sorryNotDone, ToastLength.Long);
                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}