﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class Event
{
    public Guid EventId { get; set; }

    public Guid? UserId { get; set; }

    public string EventName { get; set; }

    public DateOnly EventDate { get; set; }

    public string EventLocation { get; set; }

    public string EventDescription { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? RowStatus { get; set; }

    public virtual ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();

    public virtual ICollection<Gift> Gifts { get; set; } = new List<Gift>();

    public virtual ICollection<Guest> Guests { get; set; } = new List<Guest>();

    public virtual ICollection<Invitation> Invitations { get; set; } = new List<Invitation>();

    public virtual ICollection<Rsvp> Rsvps { get; set; } = new List<Rsvp>();

    public virtual User User { get; set; }
}