﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.GS
{
  public class UserContext
  {
    public Vault Vault { get; set; }

    public UserContext()
    {
      this.Vault = new Vault();
    }
  }
}