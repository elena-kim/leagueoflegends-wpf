﻿using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class SkillHotKey : Control
    {
        static SkillHotKey()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SkillHotKey), new FrameworkPropertyMetadata(typeof(SkillHotKey)));
        }
    }
}
