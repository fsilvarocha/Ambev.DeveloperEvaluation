using Ambev.DeveloperEvaluation.Common.Utils;

namespace Ambev.DeveloperEvaluation.Application.Products;

public interface IProductQueries
{
    Task<PaginatedList<ListProductsItemResponseDTO>> ListProductsAsync(ListProductsFilterDTO filter);
}
