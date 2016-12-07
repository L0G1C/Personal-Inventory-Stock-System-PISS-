using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using Piss.Entities.Repositories;

[assembly: OwinStartupAttribute(typeof(Piss.Startup))]
namespace Piss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddSingleton<IItemsRepository, IItemsRepository>();
        //}
    }
}
