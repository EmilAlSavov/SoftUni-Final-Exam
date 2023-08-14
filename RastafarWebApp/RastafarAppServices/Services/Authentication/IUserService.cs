using HiparAppData.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppServices.Services.Authentication
{
    public interface IUserService
    {
        public Task<ApplicationUser> GetUserByIdAsync(string id);
    }
}
