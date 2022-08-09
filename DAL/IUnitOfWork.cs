using DAL.MyContext.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IMyRepository MyRepository { get; }
        void SaveChanges();
    }

}
