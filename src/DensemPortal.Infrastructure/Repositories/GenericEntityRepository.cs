using DensemPortal.Core.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DensemPortal.Infrastructure.Repositories
{
    public class GenericEntityRepository<TEntity> : EntityRepositoryBase<DbContext, TEntity> where TEntity : EntityBase, new()
    {
		public GenericEntityRepository(ILogger<DataAccess> logger) : base(logger, null)
		{ }
	}
}