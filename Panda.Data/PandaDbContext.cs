using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Panda.Models;
using System;

namespace Panda.Data
{
    public class PandaDBContext : IdentityDbContext<PandaUser, PandaUserRole, string>
    {
        public PandaDBContext(DbContextOptions<PandaDBContext> options)
            : base(options) { }
    }
}
