using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;

namespace WPL.Web.API.Authorization.V3_1
{
  public class $($Name): AuthorizationHandler<$($Name -replace "AuthorizationHandler", "Requirement")>
  {
    public $Name()
    {
    }

    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, $($Name -replace "AuthorizationHandler", "Requirement") requirement)
    {
      throw new NotImplementedException();
    }
  }

  public class $($Name -replace "AuthorizationHandler", "Requirement"): ResourceTypeBasedRequirement, IAuthorizationRequirement
  {
    public $($Name -replace "AuthorizationHandler", "Requirement")(Type targetResourceType) : base(targetResourceType)
    {
    }
  }
}
