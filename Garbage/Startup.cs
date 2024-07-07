public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddSignalR();
        services.AddSingleton<IGameService, GameService>();  // Singleton to ensure one instance of the game
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapHub<GameHub>("/gameHub"); // adds '/gameHub' as an endpoint on the server
        });
    }
}