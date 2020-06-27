using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DiceRoller
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {

        private int sumOfRolls;
        private int totalBonus = 0;
        private int totalPenalty = 0;
        private int minRoll = 1;
        bool lastButtonWasBonus = false;
        bool lastButtonWasPenalty = false;
        bool maxPossibleRoll = true;
        bool minPossibleRoll = true;


        public MainPage()
        {
            InitializeComponent();
            startup();
            CalculateCritColour();
            

            if (Application.Current.Properties.ContainsKey("darkMode"))
            {
                PreferenceData.Instance.darkMode = (bool)Application.Current.Properties["darkMode"];
            }
            if (PreferenceData.Instance.darkMode)
            {
                setDarkMode();
            }

            setColourScheme();
        }

        private void setColourScheme()
        {
            d2.Source = string.Format("Images\\dice-{0}{1}-1d2.png", char.ToLower(PreferenceData.Instance.colourScheme[0]), PreferenceData.Instance.colourScheme.Substring(1));
            d3.Source = string.Format("Images\\dice-{0}{1}-1d3.png", char.ToLower(PreferenceData.Instance.colourScheme[0]), PreferenceData.Instance.colourScheme.Substring(1));
            d4.Source = string.Format("Images\\dice-{0}{1}-1d4.png", char.ToLower(PreferenceData.Instance.colourScheme[0]), PreferenceData.Instance.colourScheme.Substring(1));
            d6.Source = string.Format("Images\\dice-{0}{1}-1d6.png", char.ToLower(PreferenceData.Instance.colourScheme[0]), PreferenceData.Instance.colourScheme.Substring(1));
            d8.Source = string.Format("Images\\dice-{0}{1}-1d8.png", char.ToLower(PreferenceData.Instance.colourScheme[0]), PreferenceData.Instance.colourScheme.Substring(1));
            d10.Source = string.Format("Images\\dice-{0}{1}-1d10.png", char.ToLower(PreferenceData.Instance.colourScheme[0]), PreferenceData.Instance.colourScheme.Substring(1));
            d12.Source = string.Format("Images\\dice-{0}{1}-1d12.png", char.ToLower(PreferenceData.Instance.colourScheme[0]), PreferenceData.Instance.colourScheme.Substring(1));
            d20.Source = string.Format("Images\\dice-{0}{1}-1d20.png", char.ToLower(PreferenceData.Instance.colourScheme[0]), PreferenceData.Instance.colourScheme.Substring(1));
            d100.Source = string.Format("Images\\dice-{0}{1}-1d100.png", char.ToLower(PreferenceData.Instance.colourScheme[0]), PreferenceData.Instance.colourScheme.Substring(1));

            penalty.BackgroundColor = PreferenceData.Instance.colourSchemeColour;
            bonus.BackgroundColor = PreferenceData.Instance.colourSchemeColour;
            clear.BackgroundColor = PreferenceData.Instance.colourSchemeColour;
            preferences.BackgroundColor = PreferenceData.Instance.colourSchemeColour;
        }
        private void setDarkMode()
        {
            mainGrid.BackgroundColor = Color.Black;
            bonus.TextColor = Color.White;
            bonus.BackgroundColor = Color.Gray;
            penalty.TextColor = Color.White;
            penalty.BackgroundColor = Color.Gray;
            Total.TextColor = Color.White;
            diceRolls.TextColor = Color.White;
            clear.TextColor = Color.White;
            clear.BackgroundColor = Color.Gray;
            preferences.TextColor = Color.White;
            preferences.BackgroundColor = Color.Gray;
        }

        private void setLightMode()
        {
            mainGrid.BackgroundColor = Color.White;
            bonus.TextColor = Color.Black;
            bonus.BackgroundColor = Color.White;
            penalty.TextColor = Color.Black;
            penalty.BackgroundColor = Color.White;
            Total.TextColor = Color.Black;
            diceRolls.TextColor = Color.Black;
            clear.TextColor = Color.Black;
            clear.BackgroundColor = Color.White;
            preferences.TextColor = Color.Black;
            preferences.BackgroundColor = Color.White;
        }

        private void RollD2(object sender, EventArgs e)
        {

            Sounds.TapButton();

            int maxResult = 2;
            int diceResult = GenerateRandomNumber(maxResult);
            if (diceResult != maxResult )
            {
                maxPossibleRoll = false;
            }
            else if (diceResult != minRoll)
            {
                minPossibleRoll = false;
            }
            updateRolls(diceResult);
        }

        private void RollD3(object sender, EventArgs e)
        {
            Sounds.TapButton();

            int maxResult = 3;
            int diceResult = GenerateRandomNumber(maxResult);
            if (diceResult != maxResult)
            {
                maxPossibleRoll = false;
            }
            if (diceResult != minRoll)
            {
                minPossibleRoll = false;
            }
            updateRolls(diceResult);
        }

        private void RollD4(object sender, EventArgs e)
        {
            Sounds.TapButton();

            int maxResult = 4;
            int diceResult = GenerateRandomNumber(maxResult);
            if (diceResult != maxResult)
            {
                maxPossibleRoll = false;
            }
            if (diceResult != minRoll)
            {
                minPossibleRoll = false;
            }
            updateRolls(diceResult);
        }

        private void RollD6(object sender, EventArgs e)
        {
            Sounds.TapButton();


            int maxResult = 6;
            int diceResult = GenerateRandomNumber(maxResult);
            if (diceResult != maxResult)
            {
                maxPossibleRoll = false;
            }
            if (diceResult != minRoll)
            {
                minPossibleRoll = false;
            }
            updateRolls(diceResult);
        }

        private void RollD8(object sender, EventArgs e)
        {
            Sounds.TapButton();


            int maxResult = 8;
            int diceResult = GenerateRandomNumber(maxResult);
            if (diceResult != maxResult)
            {
                maxPossibleRoll = false;
            }
            if (diceResult != minRoll)
            {
                minPossibleRoll = false;
            }
            updateRolls(diceResult);
        }

        private void RollD10(object sender, EventArgs e)
        {
            Sounds.TapButton();


            int maxResult = 10;
            int diceResult = GenerateRandomNumber(maxResult);
            if (diceResult != maxResult)
            {
                maxPossibleRoll = false;
            }
            if (diceResult != minRoll)
            {
                minPossibleRoll = false;
            }
            updateRolls(diceResult);
        }

        private void RollD12(object sender, EventArgs e)
        {
            Sounds.TapButton();


            int maxResult = 12;
            int diceResult = GenerateRandomNumber(maxResult);
            if (diceResult != maxResult)
            {
                maxPossibleRoll = false;
            }
            if (diceResult != minRoll)
            {
                minPossibleRoll = false;
            }
            updateRolls(diceResult);
        }

        private void RollD20(object sender, EventArgs e)
        {
            Sounds.TapButton();


            int maxResult = 20;
            int diceResult = GenerateRandomNumber(maxResult);
            if (diceResult != maxResult)
            {
                maxPossibleRoll = false;
            }
            if (diceResult != minRoll)
            {
                minPossibleRoll = false;
            }
            updateRolls(diceResult);
        }

        private void RollD100(object sender, EventArgs e)
        {
            Sounds.TapButton();


            int maxResult = 100;
            int diceResult = GenerateRandomNumber(maxResult);
            if (diceResult != maxResult)
            {
                maxPossibleRoll = false;
            }
            if (diceResult != minRoll)
            {
                minPossibleRoll = false;
            }
            updateRolls(diceResult);
        }

        private int GenerateRandomNumber(int maxInt)
        {
            Random randomNumberGenerator = new Random();
            return randomNumberGenerator.Next(maxInt) + 1; // +1 to remove 0 and include max value 
        }

        private void updateRolls(int diceResult)
        {
            Total.ClearValue(Button.BackgroundColorProperty);
            lastButtonWasBonus = false;
            lastButtonWasPenalty = false;

            if (diceRolls.Text != "0") 
            {
                diceRolls.Text += " + " + diceResult;
            }
            else
            {
                diceRolls.Text = diceResult.ToString();
            }

            sumOfRolls += diceResult;
            Total.Text = sumOfRolls.ToString();

            CalculateCritColour();

            
            SavedData.Instance.diceRolledText = diceRolls.Text;
            SavedData.Instance.diceRolledTotalText = Total.Text;
            SavedData.Instance.minPossibleRoll = minPossibleRoll;
            SavedData.Instance.maxPossibleRoll = maxPossibleRoll;
            SavedData.Instance.lastButtonWasBonus = false;
            SavedData.Instance.lastButtonWasPenalty = false;
        }

        private void CalculateCritColour()
        {
            if (minPossibleRoll && sumOfRolls != 0)
            {
                if (PreferenceData.Instance.critMissColour == "Red")
                {
                    Total.BackgroundColor = Color.Red;
                }
                else if (PreferenceData.Instance.critMissColour == "Green")
                {
                    Total.BackgroundColor = Color.Green;
                }
                else if (PreferenceData.Instance.critMissColour == "Blue")
                {
                    Total.BackgroundColor = Color.Blue;
                }
                else
                {
                    Total.ClearValue(Button.BackgroundColorProperty);
                }
            }
            else if (maxPossibleRoll && sumOfRolls != 0)
            {
                if (PreferenceData.Instance.critHitColour == "Red")
                {
                    Total.BackgroundColor = Color.Red;
                }
                else if (PreferenceData.Instance.critHitColour == "Green")
                {
                    Total.BackgroundColor = Color.Green;
                }
                else if (PreferenceData.Instance.critHitColour == "Blue")
                {
                    Total.BackgroundColor = Color.Blue;
                }
                else
                {
                    Total.ClearValue(Button.BackgroundColorProperty);
                }
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            Sounds.TapButton();

            Total.ClearValue(Button.BackgroundColorProperty);
            maxPossibleRoll = true;
            minPossibleRoll = true;
            diceRolls.Text = "0";
            sumOfRolls = 0;
            Total.Text = "0";
            totalBonus = 0;
            totalPenalty = 0;
            bonus.Text = "+";
            penalty.Text = "-";
            SavedData.Instance.diceRolledText = diceRolls.Text;
            SavedData.Instance.diceRolledText = Total.Text;
            SavedData.Instance.maxPossibleRoll = maxPossibleRoll;
            SavedData.Instance.minPossibleRoll = minPossibleRoll;
            SavedData.Instance.totalBonus = totalBonus;
            SavedData.Instance.totalPenalty = totalPenalty;
        }

        private void plusOne(object sender, EventArgs e)
        {
            Sounds.TapButton();

            lastButtonWasPenalty = false;
            totalBonus += 1;

            bonus.Text = '+' + totalBonus.ToString();

            if (diceRolls.Text != "0")
            {
                if (lastButtonWasBonus)
                {
                   var allRolls = diceRolls.Text.Split('+').Select(Int32.Parse).ToList();
                   allRolls[allRolls.Count - 1]++;
                    diceRolls.Text = string.Join(" + ", allRolls);
                }
                else
                {
                    diceRolls.Text += " + 1";
                }
            }
            else
            {
                diceRolls.Text = "1";
            }


            sumOfRolls++;
            Total.Text = sumOfRolls.ToString();
            lastButtonWasBonus = true;
           SavedData.Instance.diceRolledText = diceRolls.Text;
            SavedData.Instance.diceRolledTotalText = Total.Text;
            SavedData.Instance.totalBonus = totalBonus;
            SavedData.Instance.lastButtonWasBonus = true;
            SavedData.Instance.lastButtonWasPenalty = false;
        }

        private void minusOne(object sender, EventArgs e)
        {
            Sounds.TapButton();

            lastButtonWasBonus = false;
            totalPenalty += 1;

            penalty.Text = '-' + totalPenalty.ToString();

            if (diceRolls.Text != "0")
            {
                if (lastButtonWasPenalty)
                {
                    var allRolls = diceRolls.Text.Split('+').Select(int.Parse).ToList();
                    allRolls[allRolls.Count - 1]--;
                    diceRolls.Text = string.Join(" + ", allRolls);
                }
                else
                {
                    diceRolls.Text += " + -1";
                }
            }
            else
            {
                diceRolls.Text = "-1";
            }


            sumOfRolls--;
            Total.Text = sumOfRolls.ToString();
            lastButtonWasPenalty = true;
            SavedData.Instance.diceRolledText = diceRolls.Text;
            SavedData.Instance.diceRolledTotalText = Total.Text;
            SavedData.Instance.totalPenalty = totalPenalty;
            SavedData.Instance.lastButtonWasBonus = false;
            SavedData.Instance.lastButtonWasPenalty = true;
        }

        private async void Preferences(object sender, EventArgs e)
        {
            Sounds.TapButton();

            Application.Current.Properties["diceRolledText"] = diceRolls.Text;
            Application.Current.Properties["diceRolledTotalText"] = Total.Text;
            Application.Current.Properties["maxPossibleRoll"] = maxPossibleRoll;
            Application.Current.Properties["minPossibleRoll"] = minPossibleRoll;
            Application.Current.Properties["totalBonus"] = totalBonus;
            Application.Current.Properties["totalPenalty"] = totalPenalty;

            Preferences preferencePage = new Preferences();
            await Navigation.PushModalAsync(preferencePage);
        }

        protected override void OnAppearing()
        {           
            if (PreferenceData.Instance.darkMode && mainGrid.BackgroundColor != Color.Black)
            {
                setDarkMode();
            }
            else if(!PreferenceData.Instance.darkMode && mainGrid.BackgroundColor != Color.White)
            {
                setLightMode();
            }

            setColourScheme();
            CalculateCritColour();
        }

        private void startup()
        {
            if (Application.Current.Properties.ContainsKey("soundEnabled"))
            {
                PreferenceData.Instance.soundEnabled = (bool)Application.Current.Properties["soundEnabled"];
                Debug.WriteLine(PreferenceData.Instance.soundEnabled);
            }

            if (Application.Current.Properties.ContainsKey("critHitColour"))
            {
                PreferenceData.Instance.critHitColour = (string)Application.Current.Properties["critHitColour"];
                Debug.WriteLine(PreferenceData.Instance.critHitColour);
            }
            else
            {
                PreferenceData.Instance.critHitColour = "Green";
            }

            if (Application.Current.Properties.ContainsKey("critMissColour"))
            {
                PreferenceData.Instance.critMissColour = (string)Application.Current.Properties["critMissColour"];
                Debug.WriteLine(PreferenceData.Instance.critMissColour);
            }
            else
            {
                PreferenceData.Instance.critMissColour = "Red";
            }

            if (Application.Current.Properties.ContainsKey("colourScheme"))
            {
                PreferenceData.Instance.colourScheme = (string)Application.Current.Properties["colourScheme"];
                Debug.WriteLine(PreferenceData.Instance.colourScheme);
            }
            else
            {
                PreferenceData.Instance.colourScheme = "Blue";
            }

            if (Application.Current.Properties.ContainsKey("diceRolledTotalText"))
            {
                Total.Text = (string)Application.Current.Properties["diceRolledTotalText"];
            }

            if (Application.Current.Properties.ContainsKey("diceRolledText"))
            {
                diceRolls.Text = (string)Application.Current.Properties["diceRolledText"];
            }

            if (Application.Current.Properties.ContainsKey("minPossibleRoll"))
            {
                minPossibleRoll = (bool)Application.Current.Properties["minPossibleRoll"];
            }

            if (Application.Current.Properties.ContainsKey("maxPossibleRoll"))
            {
                maxPossibleRoll = (bool)Application.Current.Properties["maxPossibleRoll"];
            }

            if (Application.Current.Properties.ContainsKey("totalBonus"))
            {
                totalBonus = (int)Application.Current.Properties["totalBonus"];
            }

            if (Application.Current.Properties.ContainsKey("totalPenalty"))
            {
                totalPenalty = (int)Application.Current.Properties["totalPenalty"];
            }

            if (Application.Current.Properties.ContainsKey("lastButtonWasPenalty"))
            {
                lastButtonWasPenalty = (bool)Application.Current.Properties["lastButtonWasPenalty"];
            }

            if (Application.Current.Properties.ContainsKey("lastButtonWasBonus"))
            {
                lastButtonWasBonus = (bool)Application.Current.Properties["lastButtonWasBonus"];
            }

            if (Total.Text != null)
            {
                sumOfRolls = int.Parse(Total.Text);
            }
            else
            {
                Total.Text = sumOfRolls.ToString();
            }

            if (totalBonus != 0)
            {
                bonus.Text = '+' + totalBonus.ToString();
            }
            if(totalPenalty != 0)
            {
                penalty.Text = '-' + totalPenalty.ToString();
            }
        }
    }
}
