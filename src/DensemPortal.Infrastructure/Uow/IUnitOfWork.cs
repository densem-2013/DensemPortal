﻿using System;
using System.Threading;
using System.Threading.Tasks;
using DensemPortal.Infrastructure.Repositories;

namespace DensemPortal.Infrastructure.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        IRepository<TEntity> GetRepository<TEntity>();
        TRepository GetCustomRepository<TRepository>();
    }
}
