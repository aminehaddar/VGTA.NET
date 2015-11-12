﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGTA.Data.Models;

namespace VGTA.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
       
         private vgtaContext dataContext;

        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
            dataContext = dbFactory.DataContext;
        }
        


        public void Commit()
        {
            dataContext.SaveChanges();
        }
         public void CommitAsync()
         {
             dataContext.SaveChangesAsync();
         }
        public void Dispose()
        {
            dataContext.Dispose();
        }
        public IRepositoryBaseAsync<T> getRepository<T>() where T : class
        {
            IRepositoryBaseAsync<T> repo = new RepositoryBase<T>(dbFactory);
            return repo;
        }
      
    }
}
