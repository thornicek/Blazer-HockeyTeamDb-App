using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorTeamRegistrationApp.Models;

namespace BlazorTeamRegistrationApp.Data
{
    public class BlazorTeamRegistrationContext : DbContext
    {
        public BlazorTeamRegistrationContext (DbContextOptions<BlazorTeamRegistrationContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorTeamRegistrationApp.Models.Player> Player { get; set; } = default!;
    }
}
