﻿namespace WMS.Services.DTOs.SupplyItem;

public class SupplyItemForCreateDto
{
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public int ProductId { get; set; }
}
