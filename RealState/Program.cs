using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Model;
using RealState.Utilities;
using static RealState.Utilities.Roles;

namespace RealState
{

    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<UserModel>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

			#region Authorization

			builder.Services.AddAuthorization(options =>
			{
                options.AddPolicy(AuthorizationPolicies.AdminPolicy, p => p.RequireRole(Roles.Admin));

			});
			builder.Services.AddRazorPages(options =>
			{
				options.Conventions.AuthorizeFolder("/Panel/Admin", AuthorizationPolicies.AdminPolicy);
			});

			#endregion


			//  builder.Services.AddControllersWithViews(); 

			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();
            //app.MapAreaControllerRoute

            app.Run();
        }
    }
}