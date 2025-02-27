﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BestPractice.Repository.SampleEntityCategories;

/// <summary>
/// Configures the entity model for the <see cref="SampleEntityCategory"/> class.
/// This class defines the database schema and constraints for the <see cref="SampleEntityCategory"/> entity.
/// </summary>
public class SampleEntityCategoryConfiguration : IEntityTypeConfiguration<SampleEntityCategory>
{
    /// <summary>
    /// Configures the entity properties, relationships, and constraints for the <see cref="SampleEntityCategory"/> entity.
    /// </summary>
    /// <param name="builder">The builder used to configure the entity.</param>
    public void Configure(EntityTypeBuilder<SampleEntityCategory> builder)
    {
        // Defines the primary key for the entity.
        builder.HasKey(e => e.Id);

        // Configures the 'Name' property as required with a maximum length of 150 characters.
        builder.Property(e => e.Name).IsRequired().HasMaxLength(150);
    }
}