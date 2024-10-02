using Ordering.Application.Orders.Commands.CreateOrder;

namespace Ordering.API.Endpoints
{
    public class CreateOrder : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/orders", async (CreateOrderCommand request, ISender sender) =>
            {
                var response = await sender.Send(request);

                return Results.Created($"/orders/{response.Id}", response);
            }).WithName("CreateOrder")
              .Produces<CreateOrderCommandResult>(StatusCodes.Status201Created)
              .ProducesProblem(StatusCodes.Status400BadRequest)
              .WithSummary("Create Order")
              .WithDescription("Create Order");
        }
    }
}
