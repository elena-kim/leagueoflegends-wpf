﻿using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
    public class Eternals : Control
    {
        #region DefaultStyleKey

        static Eternals()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Eternals), new FrameworkPropertyMetadata(typeof(Eternals)));
        }
        #endregion
    }
}
