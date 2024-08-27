﻿namespace Catalog.API.Products.CreateProduct
{
    public class CreateProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/products", async (CreateProductCommand command, ISender sender) =>
            {
                var response = await sender.Send(command);

                return Results.Created($"/products/{response.id}", response);
            })
              .WithName("CreateProduct")
              .Produces<CreateProductResult>(StatusCodes.Status201Created)
              .ProducesProblem(StatusCodes.Status400BadRequest)
              .WithSummary("Create Product")
              .WithDescription("Create Product");
        }
    }
}
