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
    class DatePickerFragment : DialogFragment, DatePickerDialog.IOnDateSetListener
    {
        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {
            throw new NotImplementedException();
        }
    }
}