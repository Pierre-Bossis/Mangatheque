using Mangatheque.Core.Application.Repositories;
using Mangatheque.Core.Infrastructure.Databases;
using Mangatheque.Core.Infrastructure.DataLayers;
using Mangatheque.Core.Interfaces.Infrastructures;
using Mangatheque.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
//using Mangatheque.Web.UI.Data;
//using Mangatheque.Web.UI.Areas.Identity.Data;
using Mangatheque.Core.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

string connectionstring = builder.Configuration.GetConnectionString("MangaContext");

builder.Services.AddDbContext<MangaDbContext>(options =>
{
    options.UseSqlServer(connectionstring);
});

builder.Services.AddDefaultIdentity<MangathequeWebUIUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<MangathequeWebUIContext>();
builder.Services.AddDbContext<MangathequeWebUIContext>(options=>options.UseSqlServer(connectionstring));

builder.Services.AddScoped<IMangaDataLayer, SqlServerMangaDataLayer>();
builder.Services.AddScoped<IMangaRepository, MangaRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

//app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
