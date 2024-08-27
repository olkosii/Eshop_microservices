
namespace Catalog.API.Products.DeleteProduct
{
    public class DeleteProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("products/{id}", async (Guid id, ISender sender) =>
            {
                var response = await sender.Send(new DeleteProductCommand(id));

                return Results.Ok(response);
            })
              .WithName("DeleteProduct")
              .Produces<DeleteProductResult>(StatusCodes.Status200OK)
              .ProducesProblem(StatusCodes.Status400BadRequest)
              .WithSummary("Delete Product")
              .WithDescription("Delete Product");
        }
    }
}
