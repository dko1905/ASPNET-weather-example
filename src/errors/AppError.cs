
using System.Net;

public abstract class AppError : Exception
{
    public int Code { get; init; } = 0; /* UNDEFINED ERROR */

    public AppError()
    {
    }

    public AppError(string message)
        : base(message)
    {
    }

    public AppError(string message, Exception inner)
        : base(message, inner)
    {
    }
}
