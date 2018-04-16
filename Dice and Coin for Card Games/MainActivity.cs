using Android.App;
using Android.Widget;
using Android.OS;

namespace Dice_and_Coin_for_Card_Games
{
    [Activity(Label = "Dice_and_Coin_for_Card_Games", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

