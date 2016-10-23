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

namespace UniBlu
{
    [Activity(Label = "About Us")]
    public class AboutActivity : BaseActivity
    {
        //Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.aboutLayout);
            FindViews();
            HandleEvents();
        }
/*        protected override void OnResume()
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
            }
            return base.OnOptionsItemSelected(item);
        }
*/
        private void FindViews()
        {
            this.toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(this.toolbar);
            ActionBar.SetDisplayUseLogoEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.Title = GetString(Resource.String.aboutUs);
        }
        private void HandleEvents()
        {

        }
    }
}