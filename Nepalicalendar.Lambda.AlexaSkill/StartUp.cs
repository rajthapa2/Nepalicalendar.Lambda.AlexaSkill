using Microsoft.Extensions.DependencyInjection;
using NepaliCalendar.Lambda.AlexaSkill.Services;

namespace Nepalicalendar.Lambda.AlexaSkill
{
    public class StartUp
    {
        public static ServiceProvider InitialiseServices()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }
        private static  void ConfigureServices(IServiceCollection serviceCollection)
        {
            //serviceCollection.AddTransient<ILambdaConfiguration, LambdaConfiguration>();
            serviceCollection.AddTransient<ISystemTime, SystemTime>();
            serviceCollection.AddTransient<INepaliCalendarService, NepaliCalendarService>();
        }
    }
}
