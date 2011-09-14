#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
#endregion Using Directives

namespace Core.Infrastructure.Security
{
    public struct CryptoKey
    {
        public byte[] Salt { get; set; }
        public byte[] Key { get; set; }
    }

    public class CryptographyService : ICryptographyService
    {
        protected readonly ICryptoSettings settings;

        public CryptographyService(ICryptoSettings settings)
        {
            this.settings = settings;
        }

        public CryptoKey Create(string value)
        {
            using (Rfc2898DeriveBytes derivedBytes = new Rfc2898DeriveBytes(value, settings.SaltSize))
            {
                return new CryptoKey
                {
                    Salt = derivedBytes.Salt,
                    Key = derivedBytes.GetBytes(settings.SaltSize)
                };
            }
        }

        public bool IsEqual(string value, CryptoKey key)
        {
            using (Rfc2898DeriveBytes derivedBytes = new Rfc2898DeriveBytes(value, key.Salt))
            {
                byte[] newKey = derivedBytes.GetBytes(settings.SaltSize);
                return newKey.SequenceEqual(key.Key);
            }
        }
    }
}