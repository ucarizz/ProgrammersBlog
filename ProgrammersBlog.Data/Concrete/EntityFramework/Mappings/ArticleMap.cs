using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired(true);
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired(true);
            builder.Property(a => a.SeoAuthor).IsRequired(true);
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired(true);
            builder.Property(a => a.SeoTags).IsRequired(true);
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewsCount).IsRequired(true);
            builder.Property(a => a.CommentCount).IsRequired(true);
            builder.Property(a => a.Thumbnail).IsRequired(true);
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired(true);
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired(true);
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired(true);
            builder.Property(a => a.ModifiedDate).IsRequired(true);
            builder.Property(a => a.IsDeleted).IsRequired(true);
            builder.Property(a => a.IsActive).IsRequired(true);
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");
            //builder.HasData(new Article
            //{
            //    Id = 1,
            //    CategoryId = 1,
            //    Title = "c# 256 ve olur mu böyle",
            //    Content = "C# 10'da, bir kayıt türünde geçersiz sealed kılarak ToString değiştiriciyi ekleyin." +
            //    "Yöntemi ToString mühürleme, derleyicinin türetilmiş herhangi bir kayıt türü için ToString bir yöntemi sentezleyene engel olur. , sealed ToString türetilen tüm kayıt türlerinin ortak ToString bir temel kayıt türünde tanımlanan yöntemini kullanmalarını sağlar." +
            //    "Bu özellik hakkında daha fazla bilgi için kayıtlar makalesine bakın.",
            //    Thumbnail = "",
            //    SeoAuthor = "murat uçar",
            //    SeoTags = "c#, .net",
            //    SeoDescription="test desc seo",
            //    Date = DateTime.Now,
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifiedDate = DateTime.Now,
            //    Note = "test data",
            //    UserId = 1,
            //    ViewsCount=100,
            //    CommentCount=1
            //},
            //new Article
            //{
            //    Id = 2,
            //    CategoryId = 2,
            //    Title = "java 158 ve olur mu böyle",
            //    Content = "java 10'da, bir kayıt türünde geçersiz sealed kılarak ToString değiştiriciyi ekleyin." +
            //    "Yöntemi ToString mühürleme, derleyicinin türetilmiş herhangi bir kayıt türü için ToString bir yöntemi sentezleyene engel olur. , sealed ToString türetilen tüm kayıt türlerinin ortak ToString bir temel kayıt türünde tanımlanan yöntemini kullanmalarını sağlar." +
            //    "Bu özellik hakkında daha fazla bilgi için kayıtlar makalesine bakın.",
            //    Thumbnail = "",
            //    SeoAuthor = "murat uçar",
            //    SeoTags = "c#, .net",
            //    SeoDescription = "test desc seo",
            //    Date = DateTime.Now,
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifiedDate = DateTime.Now,
            //    Note = "test data",
            //    UserId = 1,
            //    ViewsCount = 258,
            //    CommentCount = 1
            //});



        }
    }
}
