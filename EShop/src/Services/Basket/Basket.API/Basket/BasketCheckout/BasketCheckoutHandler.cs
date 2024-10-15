using BuildingBlocks.Messaging.Events;
using Mapster;
using MassTransit;

namespace Basket.API.Basket.BasketCheckout
{
    public class BasketCheckoutCommandHandler(IBasketRepository repository, IPublishEndpoint publishEndpoint) 
        : ICommandHandler<BasketCheckoutCommand, BasketCheckoutCommandResult>
    {
        public async Task<BasketCheckoutCommandResult> Handle(BasketCheckoutCommand command, CancellationToken cancellationToken)
        {
            var basket = await repository.GetBasketAsync(command.BasketCheckoutDto.UserName, cancellationToken);
            if (basket == null)
            {
                return new BasketCheckoutCommandResult(false);
            }

            var eventMessage = command.BasketCheckoutDto.Adapt<BasketCheckoutEvent>();
            eventMessage.TotalPrice = basket.TotalPrice;

            await publishEndpoint.Publish(eventMessage, cancellationToken);

            await repository.DeleteBasketAsync(command.BasketCheckoutDto.UserName, cancellationToken);

            return new BasketCheckoutCommandResult(true);
        }
    }
}
