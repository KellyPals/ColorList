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

namespace ColorList
{
    [Activity(Label = "ColorList", MainLauncher = true, Icon = "@drawable/icon")]
    public class ColorList : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Language);
            // Create your application here

            Button et = FindViewById<Button>(Resource.Id.eesti);
            Button en = FindViewById<Button>(Resource.Id.inglise);


            

            et.Click += delegate {

                var activity = new Intent(this, typeof(MainActivity));
                activity.PutExtra("Language", "ET");
                StartActivity(activity);
            };

            en.Click += delegate {
                var activity = new Intent(this, typeof(MainActivity));
                activity.PutExtra("Language", "EN");
                StartActivity(activity);
            };

        }
    }
}