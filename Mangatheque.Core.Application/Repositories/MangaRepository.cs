﻿using Mangatheque.Core.Interfaces.Infrastructures;
using Mangatheque.Core.Interfaces.Repositories;
using Mangatheque.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Application.Repositories
{
    public class MangaRepository : IMangaRepository

    {
        #region Fields
        private readonly IMangaDataLayer DataLayer;
        #endregion
        #region Constructors
        public MangaRepository(IMangaDataLayer Datalayer)
        {
            this.DataLayer = Datalayer;
        }
        #endregion

        #region public methods
        public List<Manga> GetAll(string nom)
        {
            List<Manga> list = this.DataLayer.GetList(nom);

            return list;
        }

        public List<Manga> GetAllT1()
        {
            List<Manga> list = this.DataLayer.GetListT1();

            return list;
        }

        public List<Manga> GetReadList(string id)
        {
            List<Manga> list = this.DataLayer.GetReadList(id);

            return list;
        }

        public Manga GetOne(int Id)
        {
            Manga manga = this.DataLayer.GetOne(Id);

            if(manga == null)
            {
                throw new ArgumentException("Id");
            }
            return manga;
        }

        public void Save(Manga manga)
        {
            this.DataLayer.AddOne(manga);
        }

        public void AddToReadList(int id, string idstring)
        {
            this.DataLayer.AddToReadList(id,idstring);
        }

        public void Delete(int Id)
        {
            this.DataLayer.Delete(Id);
        }

        public void DeleteFromReadList(int id, string idstring)
        {
            this.DataLayer.DeleteFromReadList(id,idstring);
        }

        public void Update(Manga Manga)
        {
            this.DataLayer.Update(Manga);
        }
        #endregion
    }
}
