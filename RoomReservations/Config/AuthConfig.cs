using Duende.IdentityServer.EntityFramework.Entities;
using RoomReservations.Models;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Test;
using System.Collections.Generic;
using System.Security.Claims;
using ApiScope = Duende.IdentityServer.EntityFramework.Entities.ApiScope;

namespace RoomReservations;

public static class AuthConfig
{
    public static IEnumerable<User> AuthUser =>
        new List<User>
        {
            IdentityResources.OpenId,
            IdentityResources.Profile
        };
    public static IEnumerable<ApiScope> ApiScopes =>
    new List<ApiScope>
    {
        new ApiScope("roomreservations", "RoomReservations"),
    }
    public static IEnumerable<Client> Clients =>
}