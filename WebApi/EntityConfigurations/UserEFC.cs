using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities;

namespace WebApi.EntityConfigurations
{
    public class UserEFC : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(c => c.Id);
            builder.ToTable("User", "OpenAiPractice");
            builder.HasData
                (
                new User { Id = 1,  AdSoyad = " Mustafa Kupik" , Adres ="Minimalist Boiler Plate by null. tech", EPosta = "null@tech.com",  Sifre = "123456", Yas = "1"}
                );
        }
    }
}
