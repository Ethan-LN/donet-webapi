namespace BuberDinner.Application;
using Microsoft.Extensions.DependencyInjection;
using BuberDinner.Application.Services.Authentication;

public static class DependencyIjenction
{
  public static IServiceCollection AddApplication(this IServiceCollection services)
  {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
  }
}