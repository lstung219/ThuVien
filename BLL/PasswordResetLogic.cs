using System;
using DAL;
using DTO;

namespace BLL
{
    public class PasswordResetLogic
    {
        public bool ResetPassword(User user)
        {
            bool success = false;

            // Check if the email exists in the database
            bool emailExists = DatabaseAccess.CheckEmailExists(user);
            if (emailExists)
            {
                // Generate a new password
                string newPassword = GenerateNewPassword();

                // Update the password in the database
                DatabaseAccess.UpdatePassword(user, newPassword);

                // Send the new password to the user via email (not implemented here)

                success = true;
            }

            return success;
        }

        private string GenerateNewPassword()
        {
            // Generate a new random password (not implemented here)
            return "123"; // Placeholder for demonstration purposes
        }
    }
}
