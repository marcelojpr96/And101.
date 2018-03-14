using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace tipCalculator
{
    [Activity(Label = "tipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        EditText inputBill;
        Button calculateButton;
        TextView outputTip;
        TextView outputTotal;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            calculateButton.Click += OnCalculateClick;


        }

        void OnCalculateClick(object sender, EventArgs e)
        {
                string text = inputBill.Text;
                var bill = double.Parse(text);

            var tip = bill * 0.15;
            var total = bill + tip;

            outputTip.Text=tip.ToString();
            outputTotal.Text = total.ToString();

            
        }
    }
}

