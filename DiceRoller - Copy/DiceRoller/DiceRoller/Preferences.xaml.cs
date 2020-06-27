using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiceRoller
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Preferences : ContentPage
    {
        public Preferences()
        {
            InitializeComponent();
            BindingContext = ColoursViewModel.Instance;

            if (PreferenceData.Instance.darkMode)
            {
                setDarkMode();
            }

            if (PreferenceData.Instance.soundEnabled == true)
            {
                soundEnabled.IsToggled = true;
            }

            if (PreferenceData.Instance.darkMode == true)
            {
                darkMode.IsToggled = true;
            }


            critHitColour.SelectedItem = PreferenceData.Instance.critHitColour;
            critMissColour.SelectedItem = PreferenceData.Instance.critMissColour;

            colourScheme.SelectedItem = PreferenceData.Instance.colourScheme;
        }

        private void SoundSwitchToggled(object sender, EventArgs e)
        {
            Sounds.TapButton();
        }

        private async void Save(object sender, EventArgs e)
        {
            PreferenceData.Instance.soundEnabled = soundEnabled.IsToggled;
            Application.Current.Properties["soundEnabled"] = PreferenceData.Instance.soundEnabled;

            PreferenceData.Instance.critHitColour = critHitColour.SelectedItem.ToString();
            PreferenceData.Instance.critMissColour = critMissColour.SelectedItem.ToString();
            Application.Current.Properties["critHitColour"] = PreferenceData.Instance.critHitColour;
            Application.Current.Properties["critMissColour"] = PreferenceData.Instance.critMissColour;

            PreferenceData.Instance.colourScheme = colourScheme.SelectedItem.ToString();
            Application.Current.Properties["colourScheme"] = PreferenceData.Instance.colourScheme;

            PreferenceData.Instance.darkMode = darkMode.IsToggled;
            Application.Current.Properties["darkMode"] = PreferenceData.Instance.darkMode;
            
            await Navigation.PopModalAsync();
        }

        private async void Cancel(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            await Navigation.PopModalAsync();
        }

        private void setDarkMode()
        {
            preferencesGrid.BackgroundColor = Color.Black;

            titleText.BackgroundColor = Color.Black;
            titleText.TextColor = Color.White;
            audioText.BackgroundColor = Color.Black;
            audioText.TextColor = Color.White;
            soundText.BackgroundColor = Color.Black;
            soundText.TextColor = Color.White;
            soundDescriptionText.BackgroundColor = Color.Black;
            soundDescriptionText.TextColor = Color.White;

            visualstext.BackgroundColor = Color.Black;
            visualstext.TextColor = Color.White;
            feedbackText.BackgroundColor = Color.Black;
            feedbackText.TextColor = Color.White;
            criticalHit.TextColor = Color.White;
            critHitColour.BackgroundColor = Color.Gray;
            critHitColour.TextColor = Color.White;
            criticalMiss.TextColor = Color.White;
            critMissColour.BackgroundColor = Color.Gray;
            critMissColour.TextColor = Color.White;

            colourSchemeText.BackgroundColor = Color.Black;
            colourSchemeText.TextColor = Color.White;
            colourScheme.BackgroundColor = Color.Gray;
            colourScheme.TextColor = Color.White;
            darkModeText.BackgroundColor = Color.Black;
            darkModeText.TextColor = Color.White;
            saveText.BackgroundColor = Color.Black;
            saveText.TextColor = Color.White;
            cancelText.BackgroundColor = Color.Black;
            cancelText.TextColor = Color.White;
        }
    }
}