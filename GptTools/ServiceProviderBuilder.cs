using Microsoft.Extensions.DependencyInjection;
using Microsoft.FluentUI.AspNetCore.Components;

namespace GptTools;
internal class ServiceProviderBuilder
{
    public static IServiceProvider Build()
    {
        var services = new ServiceCollection();
        services.AddFluentUIComponents();
        services.AddWpfBlazorWebView();
#if DEBUG
        services.AddBlazorWebViewDeveloperTools();
#endif
        return services.BuildServiceProvider();
    }
}
