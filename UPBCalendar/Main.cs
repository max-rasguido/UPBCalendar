using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace UPBCalendar
{
    [Activity(Label = "UPBCalendar", MainLauncher = true, Icon = "@drawable/icon")]
    public class Main : Activity
    {
        ListView Eventlist;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Main);
            Eventlist = FindViewById<ListView>(Resource.Id.EventList);
            EventAdapter ad = new EventAdapter();
            Eventlist.Adapter = ad;
            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

