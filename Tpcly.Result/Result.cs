using Tpcly.Result.Abstractions;

namespace Tpcly.Result
{
    public class Result : IResult
    {
        public Result(object? value = null, bool? isSuccessful = null)
        {
            Value = value;
            IsSuccessful = isSuccessful ?? value != null;
        }

        public object? Value { get; }

        public bool IsSuccessful { get; }
    }
}