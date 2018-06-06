using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections;
using System.Xml;
using System.Collections.Generic;

namespace ColorList
{
    [Activity(Label = "ColorList")]
    public class MainActivity : Activity
    {
       
        void buttonClick(object sender, EventArgs e)
        {
            string tekst = (sender as Button).Text;
            Toast.MakeText(this, tekst, ToastLength.Short).Show();
        }

        void meme(){ArrayList dank = new ArrayList();}

        protected override void OnCreate(Bundle bundle)
        {
        
            base.OnCreate(bundle);
            string language = Intent.GetStringExtra("Language");
            SetContentView(Resource.Layout.Main);
            ArrayList colors2 = new ArrayList();

            


            Resources.GetStringArray(Resource.Array.inimesed);

            string[] colors = Resources.GetStringArray(Resource.Array.colors); //õige
            string a = Resources.GetResourceName(Resource.Array.colors);
            string[] keel = Resources.GetStringArray(Resource.Array.colorsET);
            if (language == "ET")
            {
                keel = Resources.GetStringArray(Resource.Array.colorsET);
            }
            else if(language == "EN")
            {
                keel = Resources.GetStringArray(Resource.Array.colorsEN);
            }

            

            Console.WriteLine(a);

            //int colors3 = Resources.GetInteger();

            ;
   

            Console.WriteLine("PIKKUS: " + colors.Length);

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
                buttons[i].Text = keel[i].ToString();
            }

            järgmine.Click += delegate {
                StartActivity(typeof(RelativeLayoutClass));
                


            };
        }
    }
}

