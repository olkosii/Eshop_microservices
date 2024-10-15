using Ordering.Domain.Abstractions;

namespace Ordering.Application.Orders.EventHandlers.Domain
{
    public class OrderUpdatedDomainEventHandler(ILogger<OrderUpdatedDomainEventHandler> logger) : INotificationHandler<OrderUpdatedEvent>
    {
        public Task Handle(OrderUpdatedEvent domainEvent, CancellationToken cancellationToken)
        {
            logger.LogInformation("Domain Event handled: {DomainEvent}", domainEvent.GetType().Name);
            return Task.CompletedTask;
        }
    }
}
