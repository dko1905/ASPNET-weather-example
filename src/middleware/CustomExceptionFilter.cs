using System.Collections;
using System.Text.Json;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public sealed class CustomExceptionFilter : IExceptionFilter
{
    private readonly ILogger<CustomExceptionFilter> _logger;

    public CustomExceptionFilter(ILogger<CustomExceptionFilter> logger)
    {
        _logger = logger;
    }
    // public void OnException(ExceptionContext context) { }

    public void OnException(ExceptionContext context)
    {
        if (!(context.Exception is AppError)) return;

        var e = context.Exception;
        var error = new Dictionary<string, string>
            {
                {"Type", e.GetType().ToString()},
                {"Message", e.Message},
                {"StackTrace", e.StackTrace ?? ""}
            };

        foreach (DictionaryEntry data in e.Data)
            error.Add(data.Key.ToString()!, data.Value!.ToString()!);

        context.Result = new JsonResult(error, new JsonSerializerOptions() { WriteIndented = true })
        {
            StatusCode = ((AppError)context.Exception).Code
        };
    }
}
