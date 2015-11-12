using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGTA.Data.Models;

namespace VGTA.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        vgtaContext DataContext { get; }
    }

}
