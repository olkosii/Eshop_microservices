
namespace Basket.API.Basket.StoreBasket
{
    public class StoreBasketEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/basket", async(StoreBasketCommand command,ISender sender) =>
            {
                var response = await sender.Send(command);

                return Results.Created($"basket/{response.UserName}", response);
            })
                .WithName("CreateProduct")
                .Produces<StoreBasketResult>(StatusCodes.Status201Created)
                .ProducesProblem(StatusCodes.Status400BadRequest)
                .WithSummary("Create Product")
                .WithDescription("Create Product");
        }
    }
}
