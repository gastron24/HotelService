using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using RoomReservations.Data;
using Duende.IdentityServer.EntityFramework;
using Microsoft.AspNetCore.Identity;
using RoomReservations;
using RoomReservations.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RoomReservationDb>(option =>
    option.UseNpgsql());

builder.Services.AddIdentityServer()
    .AddInMemoryApiScopes(AuthConfig.ApiScopes)
    .AddInMemoryClients(AuthConfig.Clients)
    .AddAspNetIdentity<RoomReservationDb>()
    .AddDeveloperSigningCredential();
