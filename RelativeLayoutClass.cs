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
    [Activity(Label = "RelativeLayoutClass")]
    public class RelativeLayoutClass : Activity
    {

        void buttonClick(object sender, EventArgs e)
        {
            
            string tekst = (sender as Button).Text;
            Toast.MakeText(this, tekst, ToastLength.Short).Show();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RelativeLayoutt);
            string[] colors = Resources.GetStringArray(Resource.Array.colors);

            Button button = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            Button button4 = FindViewById<Button>(Resource.Id.button4);
            Button button5 = FindViewById<Button>(Resource.Id.button5);
            Button button6 = FindViewById<Button>(Resource.Id.button6);
            Button button7 = FindViewById<Button>(Resource.Id.button7);
            Button button8 = FindViewById<Button>(Resource.Id.button8);
            Button button9 = FindViewById<Button>(Resource.Id.button9);
            Button button10 = FindViewById<Button>(Resource.Id.button10);

            Button järgmine = FindViewById<Button>(Resource.Id.järgmine);

            List<Button> buttons = new List<Button> {
                button,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9,
                button10};

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].SetBackgroundColor(Android.Graphics.Color.ParseColor(colors[i].ToString()));
                buttons[i].Click += new EventHandler(buttonClick);
                Console.WriteLine(colors[i].ToString());
                buttons[i].Text = colors[i].ToString();
            }

        }

        

        


    }
}