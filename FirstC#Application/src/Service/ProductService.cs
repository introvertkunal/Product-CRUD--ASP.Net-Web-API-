using AutoMapper;
using FirstC_Application.src.Domain.Contract;
using FirstC_Application.src.Domain.Entities;
using FirstC_Application.src.Infrastructure.Context;
using static FirstC_Application.src.Domain.Contract.ProductsContract;

namespace FirstC_Application.src.Service
{
    public class ProductService : IProuductService
    {
        private readonly ProductDBContext _context;
        private readonly IMapper _mapper;
        

        public ProductService(ProductDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        

        public async Task<ProductsContract.ApiResponse<ProductsContract.ProductResponse>> CreateProduct(ProductsContract.CreateProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            product.CreatedAt = DateTime.Now;
            product.UpdatedAt = DateTime.Now;

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return new ApiResponse<ProductResponse>
            {
                Data = _mapper.Map<ProductResponse>(product),
                Success = true, 

            };
        }

        public Task<ProductsContract.ApiResponse<bool>> DeleteProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductsContract.ApiResponse<ProductsContract.ProductResponse>> GetProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductsContract.ApiResponse<IEnumerable<ProductsContract.ProductResponse>>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<ProductsContract.ApiResponse<ProductsContract.ProductResponse>> UpdateProduct(Guid id, ProductsContract.UpdateProductRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
