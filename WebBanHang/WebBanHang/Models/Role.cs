﻿using System;
using System.Collections.Generic;

namespace WebBanHang.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public string? Desciption { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
