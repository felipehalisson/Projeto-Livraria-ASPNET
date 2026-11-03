using Microsoft.EntityFrameworkCore;
using ProjetoLivraria.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<LivrariaContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("ConexaoMySQL"),
        ServerVersion.AutoDetect(
            builder.Configuration.GetConnectionString("ConexaoMySQL")
        )
    )
);

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Conta}/{action=Login}/{id?}"
);

app.Run();