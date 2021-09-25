﻿using Lol.Data.Config;
using Lol.Data.Setting.InGame;
using Lol.YamlDatabase.Entites.Schema;
using Lol.Foundation.Mvvm;
using Lol.Foundation.Riotbase;
using System.Collections.Generic;
using Lol.YamlDatabase.Controller;

namespace Lol.Settings.InGame.Local.ViewModels
{
    public class GameSoundViewModel : ObservableObject
    {
        #region Variables

        private List<UsualCodes> _musicTheme;
        #endregion

        #region Model

        public GameSoundModel Model { get; set; }
        #endregion

        #region MusicTheme

        public List<UsualCodes> MusicTheme
        {
            get => _musicTheme;
            set { _musicTheme = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public GameSoundViewModel()
        {
            MusicTheme = new CodesApi().GetCodes("000002");

            ConfigModel config = RiotConfig.LoadConfig();
            Model = config.Settings.GameSound;
        }
        #endregion
    }
}
