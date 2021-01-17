namespace JobManagement
{
    using System;
    using System.Globalization;
    using AutoMapper;
    using Models;
    using Models.Settings;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Data;
    using Factories;
    using Factories.Interfaces;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Models.Models;
    using Services;


    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.

        public static class DbInitializer
        {
            public static void Initialize(JobManagementDbContext context)
            {
                context.Database.Migrate();
            }
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            var cultureInfo = new CultureInfo("bg-BG");
            cultureInfo.NumberFormat.CurrencySymbol = "лв";

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            services.AddTransient<IEducationsService, EducationsService>();

            services.AddTransient<IBusinessSectorsService, BusinessSectorsService>();

            services.AddDbContext<JobManagementDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.Configure<EmailServerSettings>(options => Configuration.GetSection("EmailServerSettings").Bind(options));

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ISkillService, SkillService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IBusinessUserService, BusinessUserService>();
            services.AddTransient<IJobTypeService, JobTypeService>();
            services.AddTransient<IHealthStatusService, HealthStatusService>();
            services.AddTransient<IGenderService, GenderService>();
            services.AddTransient<IRegistrationUserViewModelFactory, RegistrationUserViewModelFactory>();
            services.AddTransient<IUpdateUserViewModelFactory, UpdateUserViewModelFactory>();
            services.AddTransient<IUpdateBusinessUserViewModelFactory, UpdateBusinessUserViewModelFactory>();
            services.AddTransient<IRegistrationBusinessUserViewModelFactory, RegistrationBusinessUserViewModelFactory>();
            services.AddTransient<IBusinessSectorsService, BusinessSectorsService>();
            services.AddTransient<IUserGalleryViewModelFactory, UserGalleryViewModelFactory>();
            services.AddTransient<IGalleryService, GalleryService>();
            services.AddTransient<IUserResolverService, UserResolverService>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<ITownService, TownService>();

            services.AddIdentity<BaseUser, IdentityRole<Guid>>(options =>
                {
                    options.User.RequireUniqueEmail = true;
                })
                .AddEntityFrameworkStores<JobManagementDbContext>()
                .AddDefaultTokenProviders()
                .AddErrorDescriber<CustomIdentityErrorDescriber>();


            services.AddIdentityCore<User>()
                .AddRoles<IdentityRole<Guid>>()
                .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory<User, IdentityRole>>()
                .AddEntityFrameworkStores<JobManagementDbContext>()
                .AddDefaultTokenProviders();

            services.AddIdentityCore<BusinessUser>()
                .AddRoles<IdentityRole<Guid>>()
                .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory<User, IdentityRole>>()
                .AddEntityFrameworkStores<JobManagementDbContext>()
                .AddDefaultTokenProviders();


            services.AddMvc().AddViewOptions(options =>
                options.HtmlHelperOptions.ClientValidationEnabled = true);

            services.AddAuthentication()
                .AddCookie(options => {
                    options.LoginPath = "/Account/Unauthorized/";
                    options.AccessDeniedPath = "/Account/Forbidden/";
                });

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
     
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

   

            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {

            var dbContext = serviceProvider.GetService<JobManagementDbContext>();
            DbInitializer.Initialize(dbContext);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }



            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
