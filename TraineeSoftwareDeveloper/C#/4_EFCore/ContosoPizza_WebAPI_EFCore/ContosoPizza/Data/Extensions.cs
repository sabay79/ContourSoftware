namespace ContosoPizza.Data;

public static class Extensions
{
    public static void CreateDbIfNotExists(this IHost host)
    {
        using(var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var dbContext = services.GetRequiredService<PizzaContext>();
            
            dbContext.Database.EnsureCreated();
            DbInitializer.Initialize(dbContext);

            /*
            CreateDbIfNotExists method is defined as an extension of IHost
            A reference to the PizzaContext service is created
            A reference to the PizzaContext service is created
            EnsureCreated creates a new database if one doesn't exist. The new database isn't configured for migrations, so use this with caution.
            DbIntializer.Initialize method is called, passing the PizzaContext as a parameter
            */
        }
    }
}