using System.Collections.Generic;

namespace DiceRoller.UWP
{
    public sealed partial class MainPage
    {

        public MainPage()
        {
            InitializeComponent();
            LoadApplication(new DiceRoller.App());
        }



    }
}
