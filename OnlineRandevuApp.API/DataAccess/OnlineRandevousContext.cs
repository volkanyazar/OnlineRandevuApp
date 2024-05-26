using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OnlineRandevuApp.API.Core.Concrete;
using OnlineRandevuApp.API.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.DataAccess
{
    public class OnlineRandevousContext : DbContext
    {
        public OnlineRandevousContext()
        {

        }
        public OnlineRandevousContext(DbContextOptions<OnlineRandevousContext> options ) : base(options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    //optionsBuilder.UseMySql(_configuration["ConnectionStrings:DefaultConnection"], new MySqlServerVersion(new Version(8, 0, 21))); // For Mysql
        //    optionsBuilder.UseNpgsql(_configuration["ConnectionStrings:DefaultConnection"]);
        //}

        public DbSet<User> User { get; set; }
        public DbSet<Randevous> Randevous { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Department> Department { get; set; }



    }
}
