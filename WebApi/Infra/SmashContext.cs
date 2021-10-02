using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Infra
{
    public class SmashContext : DbContext
    {
        public SmashContext(DbContextOptions options) : base(options)
        {
        }
    }
}
