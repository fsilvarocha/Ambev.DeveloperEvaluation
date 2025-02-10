using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Common.Infrastructure;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

public interface ISaleRepository : IRepository<Sale>
{
    public Task<Sale?> GetByIdAsync(Guid id);
    public Task<Sale?> GetWithSaleItemsByIdAsync(Guid id);
}
