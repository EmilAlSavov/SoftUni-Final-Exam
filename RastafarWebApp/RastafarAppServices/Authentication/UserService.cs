using HiparAppData.Data.Models;
using HiparAppServices.Services.Authentication;
using RastafarWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppServices.Authentication
{
    public class UserService : IUserService
    {
        private readonly RastafarContext context;

        public UserService(RastafarContext context)
        {
            this.context = context;
        }
        public async Task<ApplicationUser> GetUserByIdAsync(string id)
        {
            var user = await context.Users.FindAsync(id);

            return user;
        }
    }
}
