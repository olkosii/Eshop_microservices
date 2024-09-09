
namespace Basket.API.Basket.DeleteBasket
{
    public class DeleteBasketEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/basket/{userName}", async (string userName, ISender sender) =>
            {
                var response = await sender.Send(new DeleteBasketCommand(userName));

                return Results.Ok(response);
            })
                .WithName("DeleteProduct")
                .Produces<DeleteBasketResult>(StatusCodes.Status200OK)
                .ProducesProblem(StatusCodes.Status400BadRequest)
                .WithSummary("Delete Product")
                .WithDescription("Delete Product");
        }
    }
}
