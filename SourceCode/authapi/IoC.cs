using authapi.Data;
using authapi.Data.Repositories;
using authapi.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace authapi
{
    public static class IoC
    {
        public static void Create(IServiceCollection services
            , IConfiguration configuration)
        {
            services.AddDbContext<PedSMUserContext>(o => 
                o.UseSqlServer(configuration.GetConnectionString("SqlServerAuth"))
            );

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserLogRepository, UserLogRepository>();
            
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserLogService, UserLogService>();
            
            services.AddSingleton<TokenService>(
                new TokenService(configuration.GetValue<string>("SecretKey"))
            );
        }
    }
}