using BuberDinner.Api;
using BuberDinner.Api.Controllers.Errors;
using BuberDinner.Application;
using BuberDinner.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApplication()
        .AddPresentation()
        .AddInfrastructure(builder.Configuration);

}

var app = builder.Build();
{
    //app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseExceptionHandler("/error");
    // app.Map("/error", (HttpContext httpContext) =>
    // {
    //     Exception? exception = httpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
    // });
    app.UseHttpsRedirection();
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}




