﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KoiPondConstruct.Data.Models;

public partial class TblStatus
{
    public long Id { get; set; }

    public string OrderStatusName { get; set; }

    public long DesignId { get; set; }

    public string Description { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime UpdatedTime { get; set; }

    public bool IsFinal { get; set; }

    public bool IsCurrent { get; set; }

    public string EvidenceText { get; set; }

    public string EvidenceFile { get; set; }

    public bool IsDeleted { get; set; }

    public virtual TblDesign Design { get; set; }
}