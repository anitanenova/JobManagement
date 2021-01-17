using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManagement.Services
{
    using Extensions;
    using Microsoft.AspNetCore.Http;

    public class UserResolverService: IUserResolverService
    {
        private readonly IHttpContextAccessor _context;
        public UserResolverService(IHttpContextAccessor context)
        {
            _context = context;
        }

        public Guid GetUserId()
        {
            return _context.HttpContext.User.GetId();
        }
    }
}
