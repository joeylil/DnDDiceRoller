using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DiceRoller
{
    public sealed class PreferenceData
    {
        private static PreferenceData _instance = null;

        private PreferenceData() { }

        public static PreferenceData Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new PreferenceData();
                }
                return _instance;
            }
        }

        private bool _soundEnabled = true;

        public bool soundEnabled
        {
            get { return _soundEnabled; }
            set { _soundEnabled = value; }
        }

        private bool _darkMode = false;

        public bool darkMode
        {
            get { return _darkMode; }
            set { _darkMode = value; }
        }

        private string _colourScheme;

        public string colourScheme
        {
            get { return _colourScheme; }
            set { _colourScheme = value; }
        }

        public Xamarin.Forms.Color colourSchemeColour
        {
            get
            {
                if (colourScheme == "Blue")
                {
                    return Color.FromHex("1668C1");
                }
                else if ( colourScheme == "Orange")
                {
                    return Color.FromHex("C56A00");
                }
                else if (colourScheme == "Pink")
                {
                    return Color.FromHex("8F3283");
                }
                else
                {
                    return Color.FromHex("1668C1");
                }
            }
        }

        private string _critHitColour;

        public string critHitColour
        {
            get { return _critHitColour; }
            set { _critHitColour = value; }
        }

        private string _critMissColour;

        public string critMissColour
        {
            get { return _critMissColour; }
            set { _critMissColour = value; }
        }
    }
}
