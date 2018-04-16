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

namespace Dice_and_Coin_for_Card_Games
{
    /// <summary>
    ///  Create a coin, 6-sided and 20-sided dice on construction. 
    /// </summary>
    class Dice
    {
        private DataIntString SelectedDice;
        private List<DataIntString> diceList;
        public Dice()
        {
            // Default dice selected
            SelectedDice = new DataIntString(20);
            // Init new list of dice and 1 Coin
            diceList = new List<DataIntString>();
            diceList.Add(new DataIntString(6));
            diceList.Add(new DataIntString(20));
            diceList.Add(new DataIntString("Coin"));
        }

        public void setDice(DataIntString setDice)
        {
            SelectedDice = setDice;
        }

        // Paramater is instance of Random class
        // Set max value based on dice size of coin value
        public String RollDice(Random rnd)
        {
            return rnd.Next(1, DiceMaxSize()).ToString();
        }

        private int DiceMaxSize()
        {
            if (this.SelectedDice.GetValue() == "coin")
            {
                return 2;
            }
            else
            {

                return int.Parse(SelectedDice.GetValue());
            }

        }
    }

    // Class which stores an int or string value. Returns int as string 
    class DataIntString
    {
        private int? intValue = null;
        private string StringValue = null;

        public DataIntString(int intValue)
        {
            this.intValue = intValue;

        }

        public DataIntString(string StringValue)
        {
            this.StringValue = StringValue;

        }

        public String GetValue()
        {
            if (intValue.HasValue)
            {
                return this.intValue.ToString();
            }
            else
            {
                return StringValue;
            }

        }

    }
}