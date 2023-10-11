namespace Tpcly.Result.Abstractions
{
    public interface IResult<out TSuccess, out TError> : IResult
    {
        public TSuccess? Success { get; }

        public TError? Error { get; }
    }
}