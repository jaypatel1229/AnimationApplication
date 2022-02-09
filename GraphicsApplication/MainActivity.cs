using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace GraphicsApplication
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView textView;
        Button button1, button2, button3;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            textView = FindViewById<TextView>(Resource.Id.tv1);

            button1 = FindViewById<Button>(Resource.Id.viewbtn);
            button2 = FindViewById<Button>(Resource.Id.probtn);
            button3 = FindViewById<Button>(Resource.Id.Drabtn);


            button1.Click += ViewButton_Click;
            button2.Click += PropertiButton_Click;
            button3.Click += DrawButton_Click;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Intent a = new Intent(ApplicationContext, typeof(Drawable_Animation));
            StartActivity(a);
           // throw new NotImplementedException();
        }

        private void PropertiButton_Click(object sender, EventArgs e)
        {
            Intent b = new Intent(ApplicationContext,typeof(Properti_Animation));
            StartActivity(b);
            //throw new NotImplementedException();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Intent c = new Intent(ApplicationContext,typeof(View_Animation));
            StartActivity(c);
            //throw new NotImplementedException();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}