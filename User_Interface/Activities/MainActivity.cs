using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;
using User_Interface.Activities;

namespace User_Interface
{
    [Activity(Label = "Rarimard Xamarin UI - Main", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        string[] items;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            items = new string[] { "LinearLayout", "RelativeLayout", "TableLayout", "TabLayout", "TimePicker","Spinner", "AutoComplete" };
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, items);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            var t = items[position];
            switch (t)
            {
                case "LinearLayout":
                    var intent0 = new Intent(this, typeof(LinearLayout_Activity)); StartActivity(intent0);
                    break;
                case "RelativeLayout":
                    var intent1 = new Intent(this, typeof(RelativeLayout_Activity)); StartActivity(intent1);
                    break;
                case "TableLayout":
                    var intent2 = new Intent(this, typeof(TableLayout_Activity)); StartActivity(intent2);
                    break;
                case "TabLayout":
                    var intent4 = new Intent(this, typeof(TabLayout_Activity)); StartActivity(intent4);
                    break;
                case "TimePicker":
                    var intent5 = new Intent(this, typeof(TimePicker_Activity)); StartActivity(intent5);
                    break;
                case "Spinner":
                    var intent6 = new Intent(this, typeof(spinner_Activity1)); StartActivity(intent6);
                    break;
                case "AutoComplete":
                    var intent7 = new Intent(this, typeof(AutoComplete_Activity1)); StartActivity(intent7);
                    break;

            }
        }
    }
}

