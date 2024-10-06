using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using MovieList.Models;
namespace MovieList
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MovieContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("MovieContext")));
        }
    }
}
