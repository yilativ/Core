﻿#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Data
{
    public interface IConnectionFactory
    {
        string GetNameOrConnectionString();
    }
}
