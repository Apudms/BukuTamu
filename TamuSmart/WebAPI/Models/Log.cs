﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class Log
{
    public Guid LogId { get; set; }

    public Guid? UserId { get; set; }

    public string Action { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? RowStatus { get; set; }

    public virtual User User { get; set; }
}