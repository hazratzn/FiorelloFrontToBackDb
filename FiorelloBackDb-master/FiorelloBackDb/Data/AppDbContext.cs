using FiorelloBackDb.Models;
using FiorelloBackDb.Models.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloBackDb.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        #region DbSetClasses
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<AboutList> AboutLists { get; set; }
        public DbSet<FlwExpertSection> FlwExpertSection { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogSection> BlogSection { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<InstaCarouselItem> InstaCarouselItems { get; set; }
        #endregion

    }
}
