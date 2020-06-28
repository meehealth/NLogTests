using Microsoft.Owin;
using NLog;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMvc_NetFramework.Startup))]
namespace WebMvc_NetFramework
{
    public partial class Startup
    {
        static ILogger Logger = LogManager.GetCurrentClassLogger();
        public void Configuration(IAppBuilder app)
        {
            Logger.Info("Startup.Configuration");
            ConfigureAuth(app);
        }
    }
}
