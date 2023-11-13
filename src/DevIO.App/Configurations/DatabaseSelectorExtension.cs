using DevIO.App.Data;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevIO.App.Configurations
{
    public static class DatabaseSelectorExtension
    {
        public static void AddDatabaseSelector(this WebApplicationBuilder builder)
        {
            if (builder.Environment.IsDevelopment())
            {
                builder.Services.AddDbContext<MeuDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnectionLite")));

                builder.Services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnectionLite")));
            }
            else
            {
                builder.Services.AddDbContext<MeuDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

                builder.Services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            }

        }
    }
}
