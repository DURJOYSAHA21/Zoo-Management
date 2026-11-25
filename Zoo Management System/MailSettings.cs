using System;
using System.Configuration;

namespace ZooManagementSystem
{
    /// <summary>
    /// The Gmail account used to send OTP emails. The address and app password live in
    /// secrets.config (git-ignored, copied next to the .exe), never in the code.
    /// Copy secrets.example.config to secrets.config and fill it in.
    /// </summary>
    internal static class MailSettings
    {
        public static string User => Get("SmtpUser");
        public static string Password => Get("SmtpPassword");

        private static string Get(string key)
        {
            string value = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidOperationException(
                    "Email is not set up: copy secrets.example.config to secrets.config and add a Gmail address and app password.");
            return value.Trim();
        }
    }
}
