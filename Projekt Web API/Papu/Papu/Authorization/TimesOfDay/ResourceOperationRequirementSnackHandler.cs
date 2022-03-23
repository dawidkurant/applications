﻿using Microsoft.AspNetCore.Authorization;
using Papu.Entities;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Papu.Authorization.TimesOfDay
{
    public class ResourceOperationRequirementSnackHandler : AuthorizationHandler<ResourceOperationRequirement, Snack>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            ResourceOperationRequirement requirement, Snack snack)
        {
            //Sprawdzamy czy chodzi o akcję czytania i tworzenia (dostępna dla wszystkich użytkowników)
            if (requirement.ResourceOperation == ResourceOperation.Read ||
                requirement.ResourceOperation == ResourceOperation.Create)
            {
                //Zezwalamy na autoryzację
                context.Succeed(requirement);
            }

            //Przypisujemy id użytkownika 
            var userId = context.User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier).Value;

            //Sprawdzamy czy pobrane id pokrywa się z twórcą danego podwieczorka 
            if (snack.CreatedById == int.Parse(userId))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
