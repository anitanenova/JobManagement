namespace JobManagement.Extensions
{
    using System;
    using System.Linq;
    using System.Security.Claims;
    using Constants;
    using Models.Enums;

    public static class UserExtensions
    {
        public static Guid GetId(this ClaimsPrincipal user)
        {
            var identity = user?.Identity as ClaimsIdentity;
            var result = identity?.Claims.FirstOrDefault(c => c.Type == UserConstants.USER_ID_CLAIM);
            return new Guid(result?.Value);
        }

        public static UserTypeEnum? GetUserType(this ClaimsPrincipal user)
        {
            var identity = user?.Identity as ClaimsIdentity;

            var result = identity?.Claims.FirstOrDefault(c => c.Type == UserConstants.USER_TYPE_CLAIM);
            if (result == null)
            {
                return null;
            }
            Enum.TryParse(result.Value, out UserTypeEnum type);
            return type;
        }

    }
}
