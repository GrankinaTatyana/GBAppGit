using System;
using System.Collections.Generic;
using System.Text;
using DAL.MyContext.Repositories;
using Microsoft.Extensions.Logging;
using Task = System.Threading.Tasks.Task;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        //сюда добавляем все наши контексты из всех БД
        private readonly ILogger<UnitOfWork> _logger;
        public UnitOfWork(
            ILogger<UnitOfWork> logger
          )
        {
            _logger = logger;
           
        }
        public IMyRepository MyRepository => new MyRepository("");

        public void SaveChanges()
        {
        }
        #region destructor

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {

                //здесь может быть добавлен еще один контекст
                
            }

            _disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        #endregion
    }
}
