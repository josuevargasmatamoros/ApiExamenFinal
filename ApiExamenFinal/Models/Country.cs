﻿using System;
using System.Collections.Generic;

namespace ApiExamenFinal.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
