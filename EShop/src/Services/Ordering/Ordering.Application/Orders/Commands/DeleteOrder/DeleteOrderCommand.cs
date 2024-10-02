namespace Ordering.Application.Orders.Commands.DeleteOrder
{
    public record DeleteOrderCommand(Guid OrderId) : ICommand<DeleteOrderCommandResult>;
    public record DeleteOrderCommandResult(bool isSuccess);
}
