﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models;

public partial class TamuSmartDBContext : DbContext
{
    public TamuSmartDBContext(DbContextOptions<TamuSmartDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CheckIn> CheckIns { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Gift> Gifts { get; set; }

    public virtual DbSet<Guest> Guests { get; set; }

    public virtual DbSet<Invitation> Invitations { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Rsvp> Rsvps { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CheckIn>(entity =>
        {
            entity.HasKey(e => e.CheckinId).HasName("PK__CheckIns__234E211575DCD4DE");

            entity.Property(e => e.CheckinId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("checkin_id");
            entity.Property(e => e.CheckinMethod)
                .HasMaxLength(10)
                .HasDefaultValue("manual")
                .HasColumnName("checkin_method");
            entity.Property(e => e.CheckinTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("checkin_time");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("created_by");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.GuestId).HasColumnName("guest_id");
            entity.Property(e => e.RowStatus)
                .HasDefaultValue(true)
                .HasColumnName("row_status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Event).WithMany(p => p.CheckIns)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__CheckIns__event___73BA3083");

            entity.HasOne(d => d.Guest).WithMany(p => p.CheckIns)
                .HasForeignKey(d => d.GuestId)
                .HasConstraintName("FK__CheckIns__guest___72C60C4A");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__Events__2370F7276A529CD9");

            entity.Property(e => e.EventId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("event_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("created_by");
            entity.Property(e => e.EventDate).HasColumnName("event_date");
            entity.Property(e => e.EventDescription).HasColumnName("event_description");
            entity.Property(e => e.EventLocation)
                .HasMaxLength(255)
                .HasColumnName("event_location");
            entity.Property(e => e.EventName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("event_name");
            entity.Property(e => e.RowStatus)
                .HasDefaultValue(true)
                .HasColumnName("row_status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Events)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Events__user_id__4F7CD00D");
        });

        modelBuilder.Entity<Gift>(entity =>
        {
            entity.HasKey(e => e.GiftId).HasName("PK__Gifts__C1A263013C2FDC47");

            entity.Property(e => e.GiftId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("gift_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("created_by");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.GiftDescription)
                .IsRequired()
                .HasColumnName("gift_description");
            entity.Property(e => e.GiftValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("gift_value");
            entity.Property(e => e.GuestId).HasColumnName("guest_id");
            entity.Property(e => e.RowStatus)
                .HasDefaultValue(true)
                .HasColumnName("row_status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Event).WithMany(p => p.Gifts)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__Gifts__event_id__7B5B524B");

            entity.HasOne(d => d.Guest).WithMany(p => p.Gifts)
                .HasForeignKey(d => d.GuestId)
                .HasConstraintName("FK__Gifts__guest_id__7A672E12");
        });

        modelBuilder.Entity<Guest>(entity =>
        {
            entity.HasKey(e => e.GuestId).HasName("PK__Guests__19778E35FF6D8F53");

            entity.Property(e => e.GuestId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("guest_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("created_by");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("full_name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phone_number");
            entity.Property(e => e.RowStatus)
                .HasDefaultValue(true)
                .HasColumnName("row_status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Event).WithMany(p => p.Guests)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__Guests__event_id__5629CD9C");
        });

        modelBuilder.Entity<Invitation>(entity =>
        {
            entity.HasKey(e => e.InvitationId).HasName("PK__Invitati__94B74D7C2D6D84A7");

            entity.Property(e => e.InvitationId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("invitation_id");
            entity.Property(e => e.ConfirmedAt)
                .HasColumnType("datetime")
                .HasColumnName("confirmed_at");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("created_by");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.GuestId).HasColumnName("guest_id");
            entity.Property(e => e.RowStatus)
                .HasDefaultValue(true)
                .HasColumnName("row_status");
            entity.Property(e => e.SentAt)
                .HasColumnType("datetime")
                .HasColumnName("sent_at");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValue("sent")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Event).WithMany(p => p.Invitations)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__Invitatio__event__5FB337D6");

            entity.HasOne(d => d.Guest).WithMany(p => p.Invitations)
                .HasForeignKey(d => d.GuestId)
                .HasConstraintName("FK__Invitatio__guest__5EBF139D");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__Logs__9E2397E0E9043E3F");

            entity.Property(e => e.LogId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("log_id");
            entity.Property(e => e.Action)
                .IsRequired()
                .HasColumnName("action");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("created_by");
            entity.Property(e => e.RowStatus)
                .HasDefaultValue(true)
                .HasColumnName("row_status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Logs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Logs__user_id__09A971A2");
        });

        modelBuilder.Entity<Rsvp>(entity =>
        {
            entity.HasKey(e => e.RsvpId).HasName("PK__RSVP__447C7101775201A5");

            entity.ToTable("RSVP");

            entity.Property(e => e.RsvpId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("rsvp_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("created_by");
            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.GuestId).HasColumnName("guest_id");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.RowStatus)
                .HasDefaultValue(true)
                .HasColumnName("row_status");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .HasDefaultValue("maybe")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Event).WithMany(p => p.Rsvps)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__RSVP__event_id__693CA210");

            entity.HasOne(d => d.Guest).WithMany(p => p.Rsvps)
                .HasForeignKey(d => d.GuestId)
                .HasConstraintName("FK__RSVP__guest_id__68487DD7");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.SettingId).HasName("PK__Settings__256E1E323E9F520D");

            entity.Property(e => e.SettingId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("setting_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("created_by");
            entity.Property(e => e.LanguagePreferences)
                .HasMaxLength(20)
                .HasDefaultValue("en")
                .HasColumnName("language_preferences");
            entity.Property(e => e.NotificationPreferences).HasColumnName("notification_preferences");
            entity.Property(e => e.RowStatus)
                .HasDefaultValue(true)
                .HasColumnName("row_status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Settings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Settings__user_i__02FC7413");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__B9BE370F36AA810F");

            entity.HasIndex(e => e.Email, "UQ__Users__AB6E61643111C861").IsUnique();

            entity.HasIndex(e => e.Username, "UQ__Users__F3DBC57229C36513").IsUnique();

            entity.Property(e => e.UserId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("user_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasColumnName("created_by");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .HasColumnName("full_name");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(10)
                .HasDefaultValue("user")
                .HasColumnName("role");
            entity.Property(e => e.RowStatus)
                .HasDefaultValue(true)
                .HasColumnName("row_status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updated_by");
            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}