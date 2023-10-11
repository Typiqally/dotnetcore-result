using Tpcly.Result.Abstractions;

namespace Tpcly.Result
{
    public class Result<T> : Result, IResult<T>
    {
        public Result(T? value = default, bool? isSuccessful = null) : base(value, isSuccessful)
        {
            Value = value;
        }

        public new T? Value { get; }
    }
}