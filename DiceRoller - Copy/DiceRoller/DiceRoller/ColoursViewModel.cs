using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DiceRoller
{
    class ColoursViewModel
    {

        private static ColoursViewModel _instance = null;


        public static ColoursViewModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ColoursViewModel();
                }
                return _instance;
            }
        }
        private ColoursViewModel()
        {
            _critColours = new List<string>
            {
                "Red",
                "Green",
                "Blue",
                "None",
            };

            _schemeColours = new List<string>
            {
                "Blue",
                "Orange",
                "Pink",
            };
        }

        List<string> _critColours;

        public List<string> critColours
        {
            get { return _critColours; }
            private set
            {
                _critColours = value;
            }
        }

        List<string> _schemeColours;

        public List<string> schemeColours
        {
            get { return _schemeColours; }
            private set
            {
                _schemeColours = value;
            }
        }
    }
}
