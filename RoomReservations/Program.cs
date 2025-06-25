using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RoomReservations.Data;
using RoomReservations.Models;
using Duende.IdentityServer.EntityFramework.Mappers;
using Duende.IdentityServer.EntityFramework.Stores;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RoomReservationDb>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<RoomReservationDb>();
}

app.UseRouting();
app.UseIdentityServer();
app.UseAuthorization();
app.MapControllers();
app.Run();