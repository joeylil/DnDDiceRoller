using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiceRoller
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
    
        }

        protected override void OnSleep()
        {
            Application.Current.Properties["diceRolledText"] = SavedData.Instance.diceRolledText;
            Application.Current.Properties["diceRolledTotalText"] = SavedData.Instance.diceRolledTotalText;
            Application.Current.Properties["minPossibleRoll"] = SavedData.Instance.minPossibleRoll;
            Application.Current.Properties["maxPossibleRoll"] = SavedData.Instance.maxPossibleRoll;
            Application.Current.Properties["totalBonus"] = SavedData.Instance.totalBonus;
            Application.Current.Properties["totalPenalty"] = SavedData.Instance.totalPenalty;
            Application.Current.Properties["totalPenalty"] = SavedData.Instance.totalPenalty;
            Application.Current.Properties["totalPenalty"] = SavedData.Instance.totalPenalty;
            Application.Current.Properties["lastButtonWasPenalty"] = SavedData.Instance.lastButtonWasPenalty;
            Application.Current.Properties["lastButtonWasBonus"] = SavedData.Instance.lastButtonWasBonus;
        }

        protected override void OnResume()
        {            
        }
    }
}
