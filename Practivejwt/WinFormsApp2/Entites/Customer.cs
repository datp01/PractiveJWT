﻿using System;
using System.Collections.Generic;

namespace Models.Entites;

public partial class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Age { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string Salt { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Debit { get; set; }
    public int Status { get; set; }
    public string? Description { get; set; }
    public DateTime CreateDate { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime? UpdateDate { get; set; }
    public string? UpdatedBy { get; set; }
}
