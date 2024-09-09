using BuildingBlocks.Exceptions;

namespace Basket.API.Exceptions
{
    public class BasketNotFountException : NotFoundException
    {
        public BasketNotFountException(string userName) : base("Basket", userName){ }
    }
}
