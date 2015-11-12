using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGTA.Data.Models;

namespace VGTA.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private vgtaContext dataContext;
        public vgtaContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new vgtaContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
