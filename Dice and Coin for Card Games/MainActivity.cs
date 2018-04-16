using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Dice_and_Coin_for_Card_Games
{
    [Activity(Label = "Dice_and_Coin_for_Card_Games", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Random rndGen;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            // Hide the top title bar. Must be called before base.OnCreate(savedInstanceState);
            RequestWindowFeature(Android.Views.WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);

            rndGen = new Random();

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);




            var btnRollTop = FindViewById<Button>(Resource.Id.btnRollTop);
            var btnRollBot = FindViewById<Button>(Resource.Id.btnRollTop);

            btnRollBot.Click += delegate
            {
                RollDie(rndGen, btnRollBot);
            };

            btnRollTop.Click += delegate
            {
                RollDie(rndGen, btnRollTop);
            };

            
        }

        private void RollDie(Random rnd, Button btn)
        {
            Dice die = new Dice();

            btn.Text = die.RollDice(rnd);
            
        }
    }
}

