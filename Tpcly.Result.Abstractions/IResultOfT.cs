namespace Tpcly.Result.Abstractions
{
    public interface IResult<out T> : IResult
    {
        public new T? Value { get; }
    }
}