using Refit;


namespace Profit.Presentation
{
    public interface IWebClient
    {
        [Post("/v1/message")]
        public Task<long> CreateMessage([Body] Message message);
    }
}
