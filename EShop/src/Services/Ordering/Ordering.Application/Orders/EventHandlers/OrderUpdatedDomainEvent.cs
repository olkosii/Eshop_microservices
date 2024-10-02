
using Ordering.Domain.Abstractions;

namespace Ordering.Application.Orders.EventHandlers
{
    public class OrderUpdatedDomainEvent(ILogger<OrderUpdatedDomainEvent> logger) : INotificationHandler<OrderUpdatedEvent>
    {
        public Task Handle(OrderUpdatedEvent domainEvent, CancellationToken cancellationToken)
        {
            logger.LogInformation("Domain Event handled: {DomainEvent}", domainEvent.GetType().Name);
            return Task.CompletedTask;
        }
    }
}
