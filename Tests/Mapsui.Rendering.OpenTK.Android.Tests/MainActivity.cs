﻿using Android.App;
using Android.OS;
using Android.Widget;

namespace Mapsui.Rendering.OpenTK.Android.Tests
{
    [Activity(Label = "Mapsui.Rendering.OpenTK.Android.Tests", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int _count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", _count++); };
        }
    }
}

