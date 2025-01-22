using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSC.ResturantTableBookingApp.Core;

public partial class DiningTables
{
    public int Id { get; set; }


    public int RestaurantBranchId { get; set; }
    [MaxLength(100)]

    public string? TableName { get; set; }

    public int Capacity { get; set; }

    public virtual RestaurantBranch Branch { get; set; } = null!;

    public virtual ICollection<TimeSlot> TimeSlots { get; set; }=new List<TimeSlot>();

    

}
