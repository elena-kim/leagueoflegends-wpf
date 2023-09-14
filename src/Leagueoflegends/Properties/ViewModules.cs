﻿using Jamesnet.Wpf.Controls;
using Lol.Clash.UI.Views;
using Lol.Collection.UI.Views;
using Lol.GameRoom.UI.Views;
using Lol.Home.UI.Views;
using Lol.Main.UI.Views;
using Lol.Profile.UI.Views;
using Lol.Store.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Leagueoflegends.Properties
{
    public class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, TFTView>("TFTContent");
            containerRegistry.RegisterSingleton<IViewable, LootView>("LootContent");
            containerRegistry.RegisterSingleton<IViewable, EtcView>("EtcContent");
            containerRegistry.RegisterSingleton<IViewable, StoreHomeContent>("StoreHomeContent");
            containerRegistry.RegisterSingleton<IViewable, StoreChampionsContent>("StoreChampionsContent");
            containerRegistry.RegisterSingleton<IViewable, StoreSkinContent>("StoreSkinContent");
            containerRegistry.RegisterSingleton<IViewable, ItemView>("ItemContent");
            containerRegistry.RegisterSingleton<IViewable, SkinView>("SkinContent");
            containerRegistry.RegisterSingleton<IViewable, RuneView>("RuneContent");
            containerRegistry.RegisterSingleton<IViewable, SpellsView>("SpellsContent");
            containerRegistry.RegisterSingleton<IViewable, HubView>("HubContent");
            containerRegistry.RegisterSingleton<IViewable, WinnersView>("WinnersContent");
            containerRegistry.RegisterSingleton<IViewable, ChampionsView>("ChampionsContent");
            containerRegistry.RegisterSingleton<IViewable, Overview>("OverViewContent");
            containerRegistry.RegisterSingleton<IViewable, CreateCustomView>("CreateCustomContent");
            containerRegistry.RegisterSingleton<IViewable, JoinCustomView>("JoinCustomContent");
            containerRegistry.RegisterSingleton<IViewable, HistoryView>("HistoryContent");
            containerRegistry.RegisterSingleton<IViewable, PVPView>("PvpContent");
            containerRegistry.RegisterSingleton<IViewable, MainContent>("MainContent");
        }
    }
}
