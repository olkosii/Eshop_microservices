
namespace BuildingBlocks.Exceptions
{
    public class InternalServerException : Exception
    {
        public string? Details { get; set; }

        public InternalServerException(string message) : base(message) { }

        public InternalServerException(string details, string message) : base(message)
        {
            Details = details;
        }
    }
}
