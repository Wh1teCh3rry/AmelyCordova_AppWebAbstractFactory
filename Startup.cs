using AmelyCordova_AppWebAbstractFactory.AbstractFactoryPattern;

namespace AmelyCordova_AppWebAbstractFactory
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
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
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("*** Abstract Factory***\n\n");

                    await context.Response.WriteAsync("*** Haciendo un wild tiger mediante WildAnimalFactory ***\n\n");
                    //Haciendo un wild tiger mediante WildAnimalFactory
                    IAnimalFactory wildAnimalFactory = new WildAnimalFactory();
                    ITiger wildTiger = wildAnimalFactory.GetTiger();
                    wildTiger.Speak();
                    wildTiger.Action();

                    await context.Response.WriteAsync("*** Haciendo un pet dog mediante PetAnimalFactory ***\n\n");
                    //Haciendo un pet dog mediante PetAnimalFactory
                    IAnimalFactory petAnimalFactory = new PetAnimalFactory();
                    IDog petDog = petAnimalFactory.GetDog();
                    petDog.Speak();
                    petDog.Action();

                    await context.Response.WriteAsync("\n");
                });
            });
        }
    }
}
