using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Hello
{
	[Activity (Label = "Hello", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
		int count2=1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			Xamarin.Insights.Initialize (XamarinInsights.ApiKey, this);
			base.OnCreate (savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};



			Button button3 = FindViewById<Button> (Resource.Id.myButton3);
			button3.Click += delegate {
				button3.Text = string.Format ("{0} clicks!", count2++);
			};
			//Test for change
					
		}
	}
}
