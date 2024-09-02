﻿namespace WMS.Domain.QueryParameters;

public class ProductQueryParameters : QueryParametersBase
{
    public int? CategoryId { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public int? MinStockAmount { get; set; }
}
