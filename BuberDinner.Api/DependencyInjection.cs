
using BuberDinner.Api.Common.Mapping;
using BuberDinner.Api.Controllers.Errors;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddMappings();
        //builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, BuberDinnerProblemDetailsFactory>();
        return services;
    }
}