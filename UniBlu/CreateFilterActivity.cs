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
    [Activity(Label = "Create Filter Activity")]
    public class CreateFilterActivity : BaseActivity
    {
        private Button dayOffButton;
        private Button hateEarlyMorningsButton;
        private Button freeLunchButton;
        private Button doneWithFilterButton;

        private Dialog dialog;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.addFilterLayout);
            FindViews();
            SetToolBar();
            HandleEvents();
        }

        private void FindViews()
        {
            this.toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            dayOffButton = FindViewById<Button>(Resource.Id.dayOffButton);
            hateEarlyMorningsButton = FindViewById<Button>(Resource.Id.hateEarlyMorningsButton);
            freeLunchButton = FindViewById<Button>(Resource.Id.freeLunchButton);
            doneWithFilterButton = FindViewById<Button>(Resource.Id.doneWithFilterButton);
        }

        private void SetToolBar()
        {
            SetActionBar(this.toolbar);
            ActionBar.Title = GetString(Resource.String.addAFilter);
        }

        private void HandleEvents()
        {
            dayOffButton.Click += DayOffButton_Click;
            hateEarlyMorningsButton.Click += HateEarlyMorningsButton_Click;
            freeLunchButton.Click += FreeLunchButton_Click;
            doneWithFilterButton.Click += DoneWithFilterButton_Click;
        }

        private void DoneWithFilterButton_Click(object sender, EventArgs e)
        {
            //TODO Need to set this activity to go back to the scheduling page
            var intent = new Intent(this, typeof(LandingPageActivity));
            StartActivity(intent);
        }

        private void FreeLunchButton_Click(object sender, EventArgs e)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Free Up My Lunch Time!");
            alert.SetMessage("Please, no classes from 12 - 1!");
            alert.SetPositiveButton("Free Lunch", (senderAlert, args) => {
                Toast.MakeText(this, "Bring on the food!", ToastLength.Short).Show();
            });

            alert.SetNegativeButton("No Free Lunch", (senderAlert, args) => {
                Toast.MakeText(this, "I'll Eat whenever!", ToastLength.Short).Show();
            });

            Dialog dialog = alert.Create();
            dialog.Show();

        }

        private void HateEarlyMorningsButton_Click(object sender, EventArgs e)
        {
            PopupMenu menu = new PopupMenu(this, hateEarlyMorningsButton);
            menu.Inflate(Resource.Menu.hateEarlyMorningsPopupMenu);

            menu.MenuItemClick += (s1, arg1) => {
                Toast toast = Toast.MakeText(this, arg1.Item.TitleFormatted, ToastLength.Long);
                toast.SetGravity(GravityFlags.Center, 0, 0);
                toast.Show();
            };

            menu.DismissEvent += (s2, arg2) => {
                Toast toast = Toast.MakeText(this, "Menu Dismissed", ToastLength.Long);
                toast.SetGravity(GravityFlags.Center, 0, 0);
                toast.Show();
            };
            menu.Show();
        }

        private void DayOffButton_Click(object sender, EventArgs e)
        {
            dialog = new Dialog(this);
            dialog.SetContentView(Resource.Layout.DayOffLayout);            
            dialog.SetCancelable(true);

            RadioButton monday = (RadioButton)dialog.FindViewById(Resource.Id.mondayRadioButton);
            RadioButton tuesday = (RadioButton)dialog.FindViewById(Resource.Id.tuesdayRadioButton);
            RadioButton wednesday = (RadioButton)dialog.FindViewById(Resource.Id.wednesdayRadioButton);
            RadioButton thursday = (RadioButton)dialog.FindViewById(Resource.Id.thursdayRadioButton);
            RadioButton friday = (RadioButton)dialog.FindViewById(Resource.Id.fridayRadioButton);
            Button ok = (Button)dialog.FindViewById(Resource.Id.okButton);

            monday.Click += RadioButtonClick;
            tuesday.Click += RadioButtonClick;
            wednesday.Click += RadioButtonClick;
            thursday.Click += RadioButtonClick;
            friday.Click += RadioButtonClick;

            ok.Click += Ok_Click;

            dialog.Show();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            dialog.Dismiss();
        }

        private void RadioButtonClick(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            Toast.MakeText(this, rb.Text, ToastLength.Long).Show();
            dialog.Dismiss();
        }

        private void notDone()
        {
            Toast toast = Toast.MakeText(this, Resource.String.sorryNotDone, ToastLength.Long);
            toast.SetGravity(GravityFlags.Center, 0, 0);
            toast.Show();
        }
    }
}