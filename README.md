# ASP.NET Core 9.0 - Weather example app

## Structure

| Path                     | Description                                                           |
| ------------------------ | --------------------------------------------------------------------- |
| /src                     | All source code is placed here                                        |
| /src/controllers         | REST API controllers that communicate with services                   |
| /src/errors              | Custom Exception types, e.g. `NotFoundError` or `ForbiddenError`      |
| /src/middleware          | Custom middleware such as `AuthMiddleware` or `CustomExceptionFilter` |
| /src/services            | Service implementations                                               |
| /src/services/interfaces | Service interfaces                                                    |
| /src/dto                 | Domain objects for use in services                                    |
| /src/dto/in              | DTOs for parsing request body or query params FROM client         |
| /src/dto/out             | DTOs for serializing request body or query params TO client         |

## Libraries

| Name         | Description                                                                |
| ------------ | -------------------------------------------------------------------------- |
| ASP.NET Core | Framework                                                                  |
| AutoMapper   | Automatically map between domain objects and DTO objects, MIGHT BE REMOVED |
