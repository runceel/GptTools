using Microsoft.Extensions.DependencyInjection;

namespace GptTools;
internal class ServiceProviderBuilder
{
    public static IServiceProvider Build()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddWpfBlazorWebView();
        return serviceCollection.BuildServiceProvider();
    }
}
