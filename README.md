# ASP.NET Core 9.0 - Weather example app

## Structure

| Path                     | Description                                                           |
| ------------------------ | --------------------------------------------------------------------- |
| /Src                     | All source code is placed here                                        |
| /Src/Controllers         | REST API controllers that communicate with services                   |
| /Src/Errors              | Custom Exception types, e.g. `NotFoundError` or `ForbiddenError`      |
| /Src/Middleware          | Custom middleware such as `AuthMiddleware` or `CustomExceptionFilter` |
| /Src/Services            | Service implementations                                               |
| /Src/Services/Interfaces | Service interfaces                                                    |
| /Src/Domain              | Domain objects for use in services                                    |
| /Src/Domain/Dto/In       | DTOs for parsing request body or query params FROM client             |
| /Src/Domain/Dto/Out      | DTOs for serializing request body or query params TO client           |

## Libraries

| Name         | Description |
| ------------ | ----------- |
| ASP.NET Core | Framework   |
