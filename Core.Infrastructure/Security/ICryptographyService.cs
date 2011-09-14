using System;
namespace Core.Infrastructure.Security
{
    public interface ICryptographyService
    {
        CryptoKey Create(string value);
        bool IsEqual(string value, CryptoKey key);
    }
}
