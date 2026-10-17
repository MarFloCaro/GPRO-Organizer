using go.Utils;
using Xunit;

namespace go.Tests.Utils
{
    public class EncDecTests
    {
        [Fact]
        public void Encrypt_Decrypt_Roundtrip_String()
        {
            string original = "Hello GPRO!";
            string password = "testPassword123";

            string encrypted = EncDec.Encrypt(original, password);
            string decrypted = EncDec.Decrypt(encrypted, password);

            Assert.Equal(original, decrypted);
        }

        [Fact]
        public void Encrypt_Decrypt_Roundtrip_Bytes()
        {
            byte[] original = new byte[] { 1, 2, 3, 4, 5, 100, 200 };
            string password = "testPassword123";

            byte[] encrypted = EncDec.Encrypt(original, password);
            byte[] decrypted = EncDec.Decrypt(encrypted, password);

            Assert.Equal(original, decrypted);
        }

        [Fact]
        public void Encrypt_Decrypt_Roundtrip_EmptyString()
        {
            string original = "";
            string password = "testPassword123";

            string encrypted = EncDec.Encrypt(original, password);
            string decrypted = EncDec.Decrypt(encrypted, password);

            Assert.Equal(original, decrypted);
        }

        [Fact]
        public void Encrypt_Decrypt_Roundtrip_Unicode()
        {
            string original = "Héllo Wörld! àéîöü 日本語";
            string password = "p@ssw0rd!";

            string encrypted = EncDec.Encrypt(original, password);
            string decrypted = EncDec.Decrypt(encrypted, password);

            Assert.Equal(original, decrypted);
        }

        [Fact]
        public void Decrypt_WrongPassword_Fails()
        {
            string original = "secret data";
            string encrypted = EncDec.Encrypt(original, "correctPassword");

            Assert.ThrowsAny<System.Exception>(() =>
                EncDec.Decrypt(encrypted, "wrongPassword"));
        }
    }
}
