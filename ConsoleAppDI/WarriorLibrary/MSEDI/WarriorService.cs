using Microsoft.Extensions.DependencyInjection;
using DIDemo;

namespace WarriorLibrary.MSEDI
{
    public class WarriorService
    {
        IServiceCollection serviceCollection; 
        public ServiceProvider ServiceProvider;

        public WarriorService()
        {
            serviceCollection = new ServiceCollection();

            //No property injection
            //serviceCollection.AddScoped<Samurai>().AddScoped<IWeapon, Katana>();
            //serviceCollection.AddScoped<Ninja>().AddScoped<IWeapon, Sword>();
            serviceCollection.AddScoped<IWeapon, Katana>();
            serviceCollection.AddScoped<Warrior, Samurai>();
            serviceCollection.AddScoped<IWarrior, Samurai>();

            ServiceProvider = serviceCollection.BuildServiceProvider();

        }
    }
    
    
}
