namespace XGame.Domain.Extensions
{
    public static class StringExtension
    {
        private static string passwordEnhancement = "[1abip2]-ccek9006-IEK!@_@LP73-#jbasm$";

        public static string ConvertToBCrypt(this string password)
        {
            string enhancedPassword = password + passwordEnhancement;
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashPassword = BCrypt.Net.BCrypt.HashPassword(enhancedPassword, salt);

            return hashPassword;
        }

        private static bool VerifyPasswordBCrypt(this string regularPassword, string hashPassword)
        {
            string enhancedPassword = regularPassword + passwordEnhancement;
            return BCrypt.Net.BCrypt.Verify(enhancedPassword, hashPassword);
        }

    }
}
