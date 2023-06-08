using Azure.Identity;

using Sandboxable.Microsoft.Azure.KeyVault;

namespace YourNamespace
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    // Configure Key Vault options
        //    var keyVaultEndpoint = Configuration["KeyVault:Endpoint"];

        //    // Create a new instance of ManagedIdentityCredential
        //    var managedIdentityCredential = new ManagedIdentityCredential();

        //    // Configure Key Vault client
        //    var keyVaultClient = new KeyVaultClient(
        //        new KeyVaultClient.AuthenticationCallback(
        //            managedIdentityCredential.GetTokenAsync()));

        //    // Add Key Vault client to services
        //    services.AddSingleton<IKeyVaultClient>(keyVaultClient);

        //    // Add Key Vault options to services
        //    services.Configure<KeyVaultOptions>(options =>
        //    {
        //        options.Endpoint = keyVaultEndpoint;
        //    });

        //    // Other service configurations...

        //    services.AddMvc(); // Example: Adding MVC services
        //}

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // App configuration...

            app.UseRouting();

            // App middleware...

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
