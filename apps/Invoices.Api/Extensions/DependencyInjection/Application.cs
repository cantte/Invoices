using Invoices.Application.Notify;
using Invoices.Application.SearchAll;
using Invoices.Application.Update;

namespace Invoices.Api.Extensions.DependencyInjection;

public static class Application
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<InvoicesSearcher, InvoicesSearcher>();
        services.AddScoped<InvoiceNotifier, InvoiceNotifier>();
        services.AddScoped<InvoiceUpdater, InvoiceUpdater>();

        return services;
    }
}