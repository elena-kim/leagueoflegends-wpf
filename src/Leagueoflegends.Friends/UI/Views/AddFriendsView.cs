﻿using Leagueoflegends.LayoutSupport.Controls;
using System.Windows;

namespace Leagueoflegends.Friends.UI.Views
{
    public class AddFriendsView : View
    {
        #region DefaultStyleKey

        static AddFriendsView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AddFriendsView), new FrameworkPropertyMetadata(typeof(AddFriendsView)));
        }
        #endregion
    }
}
