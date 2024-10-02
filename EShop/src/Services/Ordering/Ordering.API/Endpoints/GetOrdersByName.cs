using Ordering.Application.Orders.Queries.GetOrderByName;

namespace Ordering.API.Endpoints
{
    public class GetOrdersByName : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/orders/{orderName}", async (string orderName, ISender sender) =>
            {
                var response = await sender.Send(new GetOrdersByNameQuery(orderName));

                return Results.Ok(response);
            })
            .WithName("GetOrdersByName")
            .Produces<GetOrdersByNameQueryResult>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Get Orders By Name")
            .WithDescription("Get Orders By Name");
        }
    }
}
