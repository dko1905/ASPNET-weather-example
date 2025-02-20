using System.Net;

public class NotFoundError : AppError
{
    public NotFoundError()
    {
        Code = (int)HttpStatusCode.NotFound;
    }

    public NotFoundError(string message)
        : base(message)
    {
        Code = (int)HttpStatusCode.NotFound;
    }

    public NotFoundError(string message, Exception inner)
        : base(message, inner)
    {
        Code = (int)HttpStatusCode.NotFound;
    }
}
