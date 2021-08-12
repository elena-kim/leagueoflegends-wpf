﻿using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Store.UI.Units
{
	public class FilterList : ListBox
    {
        #region DefaultStyleKey

        static FilterList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FilterList), new FrameworkPropertyMetadata(typeof(FilterList)));
        }
        #endregion

        #region GetContainerForItemOverride

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new FilterListItem();
        }
        #endregion
    }
}
