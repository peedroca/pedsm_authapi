using System.Text;

namespace authapi.Crypto
{
    internal static class SHA256 
    {
        internal static string ToCrypt(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            
            return hash.ToString();
        }
    }
}