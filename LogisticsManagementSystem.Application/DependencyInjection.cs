using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LogisticsManagementSystem.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly);
            options.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });

        // services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddValidatorsFromAssemblyContaining(typeof(DependencyInjection));
        return services;
    }
}
