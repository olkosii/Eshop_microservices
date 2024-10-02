
namespace Ordering.Application.Orders.EventHandlers
{
    public class OrderCreatedDomainEvent(ILogger<OrderCreatedDomainEvent> logger) : INotificationHandler<OrderCreatedEvent>
    {
        public Task Handle(OrderCreatedEvent domainEvent, CancellationToken cancellationToken)
        {
            logger.LogInformation("Domain Event handled: {DomainEvent}", domainEvent.GetType().Name);
            return Task.CompletedTask;
        }
    }
}
