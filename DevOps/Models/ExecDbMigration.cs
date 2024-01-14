using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DevOps.Data;

namespace DevOps.Models;

public class ExecDbMigration
{
	public static void prepMigrateDB(IApplicationBuilder builder)
	{
		using (var serviceScope = builder.ApplicationServices.CreateScope())
		{
			migrateDB(serviceScope.ServiceProvider.GetService<ApplicationDbContext>());
		}
	}

	public static void migrateDB(ApplicationDbContext context)
	{
		context.Database.Migrate();
	}
}

