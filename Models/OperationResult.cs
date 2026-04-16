// Класс для хранения результата операции (успех или ошибка)
public class OperationResult<T>
{
    // Показывает, успешна ли операция
    public bool IsSuccess { get; }
    // Значение (если успех)
    public T Value { get; }
    // Сообщение об ошибке (если неудача)
    public string Error { get; }

    // Приватный конструктор для успешного результата
    private OperationResult(T value)
    {
        IsSuccess = true;
        Value = value;
    }

    // Приватный конструктор для ошибки
    private OperationResult(string error)
    {
        IsSuccess = false;
        Error = error;
    }

    // Статический метод для создания успешного результата
    public static OperationResult<T> Success(T value)
    {
        return new OperationResult<T>(value);
    }

    public static OperationResult<T> Failure(string error)
    {
        return new OperationResult<T>(error);
    }
}
