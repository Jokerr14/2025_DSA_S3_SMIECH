using System.Security.Cryptography;
using System.Text;

namespace DSaA_Project_TimeTracker.Utils;

public static class PasswordHasher
{
    const int keySize = 64;
    const int iterations = 350000;
    static HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

    public static string HashPasword(string password)
    {
        var salt = new byte[keySize];
        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(password),
            salt,
            iterations,
            hashAlgorithm,
            keySize);

        return Convert.ToHexString(hash);
    }

    public static bool VerifyPassword(string password, string hash)
    {
        var salt = new byte[keySize];
        var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, hashAlgorithm, keySize);
        var obtainedHash = Convert.FromHexString(hash);
        return CryptographicOperations.FixedTimeEquals(hashToCompare, obtainedHash);
    }
}
