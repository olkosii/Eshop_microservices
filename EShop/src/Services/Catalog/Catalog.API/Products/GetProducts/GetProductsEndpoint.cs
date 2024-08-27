
namespace Catalog.API.Products.GetProducts
{
    public class GetProductsEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/products", async ([AsParameters] GetProductsQuery query, ISender sender) =>
            {
                var response = await sender.Send(query);

                return Results.Ok(response);
            })
              .WithName("GetProducts")
              .Produces<GetProductsResult>(StatusCodes.Status200OK)
              .ProducesProblem(StatusCodes.Status400BadRequest)
              .WithSummary("Get Products")
              .WithDescription("Get Products");
        }
    }
}
