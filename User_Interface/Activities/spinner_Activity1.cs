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

namespace User_Interface.Activities
{
    [Activity(Label = "Spinner")]
    public class spinner_Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.spinner_layout1);

            Spinner mySpinner = FindViewById<Spinner>(Resource.Id.spinner1);
            mySpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(MySpinner_ItemSelected);

            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.myStringArray, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            mySpinner.Adapter = adapter;

        }

        private void MySpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner mySpinner = (Spinner)sender;
            Toast.MakeText(this, mySpinner.GetItemAtPosition(e.Position)+" is the best pony!", ToastLength.Short).Show();
        }
    }
}