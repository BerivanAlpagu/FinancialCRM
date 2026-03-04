using BCrypt.Net;

namespace FinancialCrm.BusinessLayer.Helpers
{
    public static class PasswordHelper
    {
        // Şifreyi hash'lemek için (Kayıt olurken kullanılır)
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Girilen şifreyi DB'deki hash ile doğrulamak için (Login olurken kullanılır)
        public static bool VerifyPassword(string enteredPassword, string hashedDbPassword)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, hashedDbPassword);
        }
    }
}