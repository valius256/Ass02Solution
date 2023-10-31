﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int MemberId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime? RequireDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public decimal? Freight { get; set; }
}
