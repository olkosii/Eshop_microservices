
namespace Basket.API.Basket.GetBasket
{
    public class GetBasketHandler(IBasketRepository _basketRepository) : IQueryHandler<GetBasketQuery, GetBasketResult>
    {
        public async Task<GetBasketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
        {
            var basket = await _basketRepository.GetBasketAsync(query.UserName);

            return new GetBasketResult(basket);
        }
    }
}
