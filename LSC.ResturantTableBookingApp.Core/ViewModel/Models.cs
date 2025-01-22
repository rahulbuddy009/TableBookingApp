﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSC.ResturantTableBookingApp.Core.ViewModel
{
    public class ResturantModels
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? ImageUrl { get; set; }
    }
    public class ResturantBranchModel
    {
        public int Id { get; set; }
        public int ResturantId { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? ImageUrl { get; set; }
    }

    public class DiningTableWithTimeSlotsModel
    {
        public int BranchId { get; set; }
        public DateTime ReservationDay { get; set; }
        public string?  TableName { get; set; }
        public int Capacity { get; set; }
        public string MealType { get; set; } = null;
        public string TableStatus { get; set; } = null;
        public int TimeSlotId { get; set; }
    }


}
