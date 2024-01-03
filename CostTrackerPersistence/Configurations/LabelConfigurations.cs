using CostTrackerDomain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CostTrackerPersistence.Configurations;

public class LabelConfigurations : IEntityTypeConfiguration<Label>
{
    public void Configure(EntityTypeBuilder<Label> builder)
    {
        ConfigureLabelTable(builder);        
    }

    private void ConfigureLabelTable(EntityTypeBuilder<Label> builder)
    {
        builder.ToTable("Labels");

        builder.HasKey(m=>m.Id);

        builder.Property(m => m.Id)
            .ValueGeneratedNever();
    }
}
