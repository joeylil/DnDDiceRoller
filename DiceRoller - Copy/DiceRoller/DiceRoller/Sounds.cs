using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    class Sounds
    {
        static Plugin.SimpleAudioPlayer.ISimpleAudioPlayer Player = null;

        public static void TapButton()
        {
            if(PreferenceData.Instance.soundEnabled == false)
            {
                return;
            }
            if(Player == null)
            {
                Player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                Player.Load("tap.wav");
            }
            Player.Play();
        }
    }
}
