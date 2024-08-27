
namespace Catalog.API.Products.GetProductById
{
    public class GetProductByIdEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/products/{id}", async (Guid id, ISender sender) =>
            {
                var response = await sender.Send(new GetProductByIdQuery(id));

                return Results.Ok(response);
            })
             .WithName("GetProductById")
             .Produces<GetProductByIdResult>(StatusCodes.Status200OK)
             .ProducesProblem(StatusCodes.Status400BadRequest)
             .WithSummary("Get Product")
             .WithDescription("Get Product");
        }
    }
}
