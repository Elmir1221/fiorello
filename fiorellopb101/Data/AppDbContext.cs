using fiorellopb101.Models;
using Microsoft.EntityFrameworkCore;

namespace fiorellopb101.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfo { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Product>().HasQueryFilter(m => !m.SoftDeleted);




            modelBuilder.Entity<Blog>().HasData(
               new Blog
               {
                   Id =1,
                   Title="REsadin Blogu",
                   Description= "Resadin Blogu",
                   Image = "blog-feature-img-1.jpg",
                   CreatedDate = DateTime.Now

               },
            new Blog
            {
                Id = 2,
                Title = "Behruzun Blogu",
                Description = "Resadin Blogu",
                Image = "blog-feature-img-2.jpg",
                CreatedDate = DateTime.Now

            },
            new Blog
            {
                Id = 3,
                Title = "Ilqarin Blogu",
                Description = "Ilqarin Blogu",
                Image = "blog-feature-img-3.jpg",
                CreatedDate = DateTime.Now

            });

        }
    }

}
