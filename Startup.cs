using Services;
using Hubs;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();  // registers services to handle HTTP requests in GameHub.cs
        services.AddSignalR(); // enables server-client asynchronous communication
        services.AddSingleton<IGameService, GameService>();  // Singleton to ensure one instance of GameService
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        /*
        * Configures the application to include the endpoint '/gameHub'; this is where the GameService is hosted
        */
        if (env.IsDevelopment())  // if dev environment (launchSettings.json)
        {
            app.UseDeveloperExceptionPage();  // shows exception page with detailed info to help with debugging server operations
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapHub<GameHub>("/gameHub"); // adds '/gameHub' as an endpoint on the server and makes it a representation of GameHub.cs
        });
    }
}