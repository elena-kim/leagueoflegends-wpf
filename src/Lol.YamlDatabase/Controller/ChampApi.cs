﻿using Lol.YamlDatabase.Common;
using Lol.YamlDatabase.Entites.Core;
using Lol.YamlDatabase.Entites.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Lol.YamlDatabase.Controller
{
    public class ChampApi : LolDbContext
    {
        #region GetChamps

        public List<Champs> GetChamps()
        {
            var query = from c in Db.Champs
                        select new Champs
                        {
                            Seq = c.Seq,
                            Champ = c.Champ,
                            Name = c.Name,
                            Img = ResourceHelper.ImgResource(c.Img),
                            Insignia = ResourceHelper.ImgResource(c.Insignia)
                        };
            return query.ToList();
        }
        #endregion

        #region GetChampCb1

        public List<ChampCb> GetChampCb1()
        {
            var query = from c in Db.ChampCb
                        where c.Type == 0
                        select new ChampCb
                        {
                            Seq = c.Seq,
                            Content = c.Content,
                            Type = c.Type
                        };
            return query.ToList();
        }
        #endregion

        #region GetChampCb2

        public List<ChampCb> GetChampCb2()
        {
            var query = from c in Db.ChampCb
                        where c.Type == 1
                        select new ChampCb
                        {
                            Seq = c.Seq,
                            Content = c.Content,
                            Type = c.Type
                        };
            return query.ToList();
        }
        #endregion
    }
}
