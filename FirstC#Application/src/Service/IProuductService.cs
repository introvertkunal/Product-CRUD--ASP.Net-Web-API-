using Microsoft.AspNetCore.Mvc.ApiExplorer;
using static FirstC_Application.src.Domain.Contract.ProductsContract;

namespace FirstC_Application.src.Service
{
    public interface IProuductService
    {
        Task<ApiResponse<ProductResponse>> GetProduct(Guid id);
        Task<ApiResponse<IEnumerable<ProductResponse>>> GetProducts();

        Task<ApiResponse<ProductResponse>> CreateProduct(CreateProductRequest request);

        Task<ApiResponse<ProductResponse>> UpdateProduct(Guid id, UpdateProductRequest request);

        Task<ApiResponse<bool>> DeleteProduct(Guid id);
    }
}
