
namespace Ordering.Application.Orders.Commands.UpdateOrder
{
    public record UpdateOrderCommand(OrderDto Order) : ICommand<UpdateOrderCommandResult>;
    public record UpdateOrderCommandResult(bool IsSuccess);
}
