using System.Security.Claims;
using ConcertTickets.Data;
using ConcertTickets.Repositories;
using ConcertTickets.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Services
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IConcertService, ConcertService>();
builder.Services.AddScoped<ITicketOfferService, TicketOfferService>();

// Repositories
builder.Services.AddScoped<IConcertRepository, ConcertRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ITicketOfferRepository, TicketOfferRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// Sessions
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();


builder.Services.AddDefaultIdentity<CustomUser>(options =>
{
    // Geen bevestiging nodig
    options.SignIn.RequireConfirmedAccount = false;

    // Password restricties
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;

    // Lockout
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
})
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

// Admin Policy Authorization
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy =>
        policy.RequireClaim("isAdmin", "true"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Admin Seeding
using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    await SeedAdminUserAsync(serviceProvider);
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Concert}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();


static async Task SeedAdminUserAsync(IServiceProvider serviceProvider)
{
    const string ADMIN_ACCOUNT = "admin@test.be";
    const string ADMIN_PASSWORD = "Admin@123";

    using var scope = serviceProvider.CreateScope();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<CustomUser>>();

    var user = await userManager.FindByEmailAsync(ADMIN_ACCOUNT);
    if (user == null)
    {
        user = new CustomUser
        {
            FirstName = "Admin",
            LastName = "User",
            UserName = ADMIN_ACCOUNT,
            Email = ADMIN_ACCOUNT,
            EmailConfirmed = true
        };

        await userManager.CreateAsync(user, ADMIN_PASSWORD);
    }

    if (!(await userManager.GetClaimsAsync(user)).Any(c => c.Type == "isAdmin"))
    {
        await userManager.AddClaimAsync(user, new Claim("isAdmin", "true"));
    }
}
