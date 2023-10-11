namespace Tpcly.Result.Abstractions
{
    public interface IResult
    {
        public object? Value { get; }

        public bool IsSuccessful { get; }
    }
}