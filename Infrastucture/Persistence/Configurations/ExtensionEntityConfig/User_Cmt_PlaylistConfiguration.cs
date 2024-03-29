﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Configurations.BaseConfig;

namespace Persistence.Configurations
{
    public class User_Cmt_PlaylistConfiguration : ExtensionEntityConfiguration<User_Cmt_Playlist>, IEntityTypeConfiguration<User_Cmt_Playlist>
    {
        public void Configure(EntityTypeBuilder<User_Cmt_Playlist> builder)
        {
            ConfigureExtensionEntityBase(ref builder);
            builder.HasKey(t => t.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.PlaylistId).IsRequired();
            builder.Property(t => t.UserId).IsRequired();
            builder.Property(t => t.DateCreate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(t => t.Content).IsRequired().HasMaxLength(1000);
            builder.ToTable("User_Cmt_Playlist");
            builder.HasOne(s => s.PlayList).WithMany(u => u.ListUserCmt)
                .HasForeignKey(u => u.PlaylistId);
            builder.HasOne(u => u.User).WithMany(s => s.ListPlaylistCmt)
              .HasForeignKey(s => s.UserId);
        }
    }

}
