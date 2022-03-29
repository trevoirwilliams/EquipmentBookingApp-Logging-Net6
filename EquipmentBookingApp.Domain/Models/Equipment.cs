﻿namespace EquipmentBookingApp.Domain.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? Category { get; set; }
    }
}