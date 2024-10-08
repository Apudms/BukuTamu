﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class Guest
{
    public Guid GuestId { get; set; }

    public Guid? EventId { get; set; }

    public string FullName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Address { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? RowStatus { get; set; }

    public virtual ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();

    public virtual Event Event { get; set; }

    public virtual ICollection<Gift> Gifts { get; set; } = new List<Gift>();

    public virtual ICollection<Invitation> Invitations { get; set; } = new List<Invitation>();

    public virtual ICollection<Rsvp> Rsvps { get; set; } = new List<Rsvp>();
}