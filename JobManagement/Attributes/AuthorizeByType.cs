namespace JobManagement.Attributes
{
    using System.Linq;

    using Extensions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Models.Enums;

    public class AuthorizeByType: AuthorizeAttribute, IAuthorizationFilter
    {

        private readonly UserTypeEnum[] _types;

        public AuthorizeByType(params UserTypeEnum[] types)
        {
            _types = types;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                return;
            }

            var currentUserType = context.HttpContext.User.GetUserType();

            if (_types.All(x=>x != currentUserType))
            {
                context.Result = new ForbidResult();
            }
        }
    }
}
