
namespace Catalog.API.Products.UpdateProductById
{
    public class UpdateProductCommandEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/products", async (UpdateProductCommand command, ISender sender) =>
            {
                var response = await sender.Send(command);

                return Results.Ok(response);
            })
              .WithName("UpdateProduct")
              .Produces<UpdateProductResult>(StatusCodes.Status200OK)
              .ProducesProblem(StatusCodes.Status400BadRequest)
              .WithSummary("Update Product")
              .WithDescription("Update Product");
        }
    }
}
