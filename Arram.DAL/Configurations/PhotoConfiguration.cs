﻿using Arram.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Arram.Core.DAL.Configurations
{
  public class PhotoConfiguration
  {
    public PhotoConfiguration(EntityTypeBuilder<Photo> entity)
    {

      //entity.Property(e => e.SuppressorId).HasColumnName("SuppressorID");
      //entity.Property(e => e.IsDeleted).HasColumnName("isDeleted").HasDefaultValueSql("(0)");
      //entity.Property(e => e.DateCreation).HasDefaultValueSql("(getutcdate())");
      //entity.Property(e => e.DateModification).HasDefaultValueSql("(getutcdate())");
    }
  }
}
