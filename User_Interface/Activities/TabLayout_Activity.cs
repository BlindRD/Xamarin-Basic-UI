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

namespace User_Interface
{
    [Activity(Label = "TabLayout")]
    public class TabLayout_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs; // create an Action bar
            SetContentView(Resource.Layout.TabLayout_Layout); // set out layout

            ActionBar.Tab t1 =  ActionBar.NewTab();
            t1.SetText("One");
            t1.TabSelected += T1_TabSelected;
            ActionBar.AddTab(t1);

            ActionBar.Tab t2 = ActionBar.NewTab();
            t2.SetText("Two");
            t2.TabSelected += T2_TabSelected;
            ActionBar.AddTab(t2);

            ActionBar.Tab t3 = ActionBar.NewTab();
            t3.SetText("Three");
            t3.TabSelected += T3_TabSelected;
            ActionBar.AddTab(t3);

        }

        private void T3_TabSelected(object sender, ActionBar.TabEventArgs e)
        {
            Toast.MakeText(this, "t3", ToastLength.Short).Show();
        }

        private void T2_TabSelected(object sender, ActionBar.TabEventArgs e)
        {
            Toast.MakeText(this, "t2", ToastLength.Short).Show();
        }

        private void T1_TabSelected(object sender, ActionBar.TabEventArgs e)
        {
            Toast.MakeText(this, "t1", ToastLength.Short).Show();
        }
    }
}