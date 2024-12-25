using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace fluentApi.Configs;

public class UserFluentConfig : IEntityTypeConfiguration<UserFluent>
{
    public void Configure(EntityTypeBuilder<UserFluent> d)
    {
        d.ToTable("MyUserFluents");
        d.HasKey(d => d.Id);
        d.Property(d => d.Id).ValueGeneratedOnAdd();
        d.Property(d => d.Age).IsRequired();
        d.Ignore(d => d.BirthDate);
        d.Ignore(d => d.Dummy);
        d.Property(d => d.Gender).HasConversion<string>();
        var valueConvertor = new ValueConverter<NationalCode, string>
            (n => n.PersonalCode, s => new NationalCode(s));
        d.Property(d => d.NationalCode).HasConversion(valueConvertor);

        d.Property(c => c.FullName).HasConversion(f => JsonConvert.SerializeObject(f),
            s => JsonConvert.DiserializeObject<FullName>(s));
    }
}