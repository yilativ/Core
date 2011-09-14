#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion Using Directives

namespace Core.Infrastructure.Security
{
    public interface ICryptoSettings
    {
        int SaltSize { get; set; }
    }

    public class CryptoSettings : ICryptoSettings
    {
        public int SaltSize
        {
            get;
            set;
        }

        public CryptoSettings()
        {
            SaltSize = 30;
        }
    }
}