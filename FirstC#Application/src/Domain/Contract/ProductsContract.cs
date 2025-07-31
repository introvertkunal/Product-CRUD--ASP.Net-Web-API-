namespace FirstC_Application.src.Domain.Contract
{
    public class ProductsContract
    {
        public record CreateProductRequest(string? Name, string? Description, decimal Price);

        public record UpdateProductRequest(string? Name, string? Description, decimal Price);

        public record ProductResponse(Guid Id, string? Name, string? Description, decimal Price, DateTime CreatedAt, DateTime UpdatedAt);


        public class ApiResponse<T>
        {
           public T? Data { get; set; }

           public bool Success { get; set; }


            public string? Message { get; set; } 







        }


    }
}
