using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace HelloWorld
{
	[Activity (Label = "HelloWorld", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
		EditText ed;

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

			Button button2 = FindViewById<Button> (Resource.Id.myButton2);

			button2.Click += delegate {
				ed = FindViewById<EditText> (Resource.Id.myText);
				string st = ed.Text;
				Console.WriteLine(st);

			};
		}
	}
}
