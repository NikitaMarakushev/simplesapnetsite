using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using simplesapnetsite.Domain.Entities;
using System;

namespace simplesapnetsite.Domain
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ServiceItem>().HasData(new IdentityRole
            {
                Id = "9op01189-b018-4fe7-a356-7g8a14c70b78",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<ServiceItem>().HasData(new IdentityUser
            {
                Id = "9op11189-b018-4fe7-a356-7g8a14c70b99",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "email@email.com",
                NormalizedEmail = "EMAIL@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superuserpassword"),
                SecurityStamp = String.Empty
            });

            modelBuilder.Entity<ServiceItem>().HasData(new IdentityUserRole<string>
            {
                RoleId = "9op01189-b018-4fe7-a356-7g8a14c70b78",
                UserId = "9op11189-b018-4fe7-a356-7g8a14c70b99"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("65p11189-b018-4fe7-a356-7g8a16c70b99"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("32p09289-r224-4fe7-a909-7g8a14c72b99"),
                CodeWord = "PageServices",
                Title = "Наши услуги"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("13r11189-z009-6fe9-a356-7g8a14c71b99"),
                CodeWord = "PageContacts",
                Title = "Контакы"
            });
        }
    } 
}
