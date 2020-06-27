using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    public sealed class SavedData
    {
        private static SavedData _instance = null;

        private SavedData() { }

        public static SavedData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SavedData();
                }
                return _instance;
            }
        }

        private string _diceRolledText;
        public string diceRolledText
        {
            get { return _diceRolledText; }
            set { _diceRolledText = value; }
        }

        private string _diceRolledTotalText;
        public string diceRolledTotalText
        {
            get { return _diceRolledTotalText; }
            set { _diceRolledTotalText = value; }
        }

        private bool _maxPossibleRoll;
        public bool maxPossibleRoll
        {
            get { return _maxPossibleRoll; }
            set { _maxPossibleRoll = value; }
        }

        private bool _minPossibleRoll;
        public bool minPossibleRoll
        {
            get { return _minPossibleRoll; }
            set { _minPossibleRoll = value; }
        }

        private int _totalBonus;
        public int totalBonus
        {
            get { return _totalBonus; }
            set { _totalBonus = value; }
        }

        private int _totalPenalty;
        public int totalPenalty
        {
            get { return _totalPenalty; }
            set { _totalPenalty = value; }
        }

        private bool _lastButtonWasBonus;
        public bool lastButtonWasBonus
        {
            get { return _lastButtonWasBonus; }
            set { _lastButtonWasBonus = value; }
        }

        private bool _lastButtonWasPenalty;
        public bool lastButtonWasPenalty
        {
            get { return _lastButtonWasPenalty; }
            set { _lastButtonWasPenalty = value; }
        }
    }
}
