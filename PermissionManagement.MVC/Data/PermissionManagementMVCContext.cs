using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PermissionManagement.MVC.Models;

namespace PermissionManagement.MVC.Data
{
    public class PermissionManagementMVCContext : DbContext
    {
        public PermissionManagementMVCContext (DbContextOptions<PermissionManagementMVCContext> options)
            : base(options)
        {
        }

        public DbSet<PermissionManagement.MVC.Models.Flight> Flight { get; set; }

        public DbSet<PermissionManagement.MVC.Models.Passenger> Passenger { get; set; }

        public DbSet<PermissionManagement.MVC.Models.User> User { get; set; }
    }
}
