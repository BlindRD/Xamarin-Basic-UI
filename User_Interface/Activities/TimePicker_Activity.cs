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
    [Activity(Label = "TimePicker")]
    public class TimePicker_Activity : Activity
    {

        public TextView myTextVie;
        public Button timebtn;

        public int hour;
        public int min;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.timepicker_layout1);

            myTextVie = FindViewById<TextView>(Resource.Id.textView35);
            timebtn = FindViewById<Button>(Resource.Id.button1);
            timebtn.Click += timeDoThing;

            hour = DateTime.Now.Hour;
            min = DateTime.Now.Minute;

            UpdateDisplay();

        }

        private void UpdateDisplay()
        {
            myTextVie.Text = (hour + ":" + min).ToString();
        }

        private void timeDoThing(object sender, EventArgs e)
        {
            ShowDialog(0);
        }

        private void TimePickerCallback(object sender, TimePickerDialog.TimeSetEventArgs e)
        {
            hour = e.HourOfDay;
            min = e.Minute;
            UpdateDisplay();
        }

        protected override Dialog OnCreateDialog(int id)
        {
            if (id == 0)
                return new TimePickerDialog(this, TimePickerCallback, hour, min, false);

            return null;
        }
    }
}