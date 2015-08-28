using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Random_Number_Gen_MVC.Startup))]
namespace Random_Number_Gen_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
