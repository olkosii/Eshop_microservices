namespace Ordering.Application.Orders.Queries.GetOrderByName
{
    public record GetOrdersByNameQuery(string OrderName) : IQuery<GetOrdersByNameQueryResult>;

    public record GetOrdersByNameQueryResult(IEnumerable<OrderDto> orders);
}
