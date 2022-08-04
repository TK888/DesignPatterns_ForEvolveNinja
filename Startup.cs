using NinjaAPI_ForEvolve.Interfaces;
using NinjaAPI_ForEvolve.Services;

namespace NinjaAPI_ForEvolve
{
    public class Startup
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IChildService, ChildService>();
            services.AddMvc();
        }

    }
}
