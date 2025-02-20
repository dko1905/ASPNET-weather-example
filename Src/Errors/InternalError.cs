using System.Net;

public class InternalError : AppError
{
    public InternalError()
    {
        Code = (int)HttpStatusCode.InternalServerError;
    }

    public InternalError(string message)
        : base(message)
    {
        Code = (int)HttpStatusCode.InternalServerError;
    }

    public InternalError(string message, Exception inner)
        : base(message, inner)
    {
        Code = (int)HttpStatusCode.InternalServerError;
    }
}
