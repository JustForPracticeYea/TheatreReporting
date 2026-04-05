using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TheatreReportingApp.Components;
using TheatreReportingApp.Models;
using TheatreReportingApp.DtoAndHelpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<TheatreDbContext>(options => options.UseSqlite(connectionString));

builder.Services.AddIdentity<Users, IdentityRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequiredUniqueChars = 3;
})
.AddEntityFrameworkStores<TheatreDbContext>()
.AddDefaultTokenProviders()
.AddErrorDescriber<RussianIdentityErrorsDescriber>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.MaxAge = null;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    options.SlidingExpiration = true;
    options.LoginPath = "/Login";
});

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();


builder.Services.AddAntDesign();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

/*using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<Users>>();
    var roles = new[] { "Admin" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
    var userName = "admin@mail.com";
    var email = "admin@mail.com";
    var password = "Admin123!";
    var surname = "Мумжа";
    var name = "Алексей";
    var fatherName = "Павлович";
    var user = new Users { UserName = userName, Email = email, Surname = surname, Name = name, Fathername = fatherName };
    var createResult = await userManager.CreateAsync(user, password);
    var addRoleResult = await userManager.AddToRoleAsync(user, "Admin");
}*/

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapPost("/logout", async (SignInManager<Users> signInManager) =>
{
    await signInManager.SignOutAsync();
    return Results.Redirect("/Login");
});

app.Run();
