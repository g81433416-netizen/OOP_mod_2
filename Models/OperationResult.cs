public class OperationResult<T>
{
    public bool IsSuccess { get; }
    public T Value { get; }
    public string Error { get; }

    private OperationResult(T value)
    {
        IsSuccess = true;
        Value = value;
    }

    private OperationResult(string error)
    {
        IsSuccess = false;
        Error = error;
    }

    public static OperationResult<T> Success(T value)
    {
        return new OperationResult<T>(value);
    }

    public static OperationResult<T> Failure(string error)
    {
        return new OperationResult<T>(error);
    }
}