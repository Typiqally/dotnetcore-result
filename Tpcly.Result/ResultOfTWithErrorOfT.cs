using Tpcly.Result.Abstractions;

namespace Tpcly.Result
{
    public class Result<TSuccess, TError> : Result, IResult<TSuccess, TError>
    {
        public Result()
        {
        }

        public Result(TSuccess? success) : base(success, true)
        {
            Success = success;
        }

        public Result(TError? error) : base(error, false)
        {
            Error = error;
        }

        public TSuccess? Success { get; }

        public TError? Error { get; }
    }
}