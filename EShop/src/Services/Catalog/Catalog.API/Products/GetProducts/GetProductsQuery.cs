namespace Catalog.API.Products.GetProducts
{
    public record GetProductsQuery(int? pageNumber, int? pageSize) : IQuery<GetProductsResult>;
    public record GetProductsResult(IEnumerable<Product> Products);
}
