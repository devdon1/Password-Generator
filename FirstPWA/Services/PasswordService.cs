using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstPWA.Services
{
    public class PasswordService : IPasswordService
    {
        public string GeneratePassword(int passwordLength)
        {
            char[] chars = GeneratePasswordCharacters();

            string[] password = new string[passwordLength];

            for (int i = 0; i < passwordLength; i++)
            {
                password[i] = GetRandomCharacter(chars);
            }

            return String.Concat(password);
        }

        private char[] GeneratePasswordCharacters()
        {
            char[] passwordChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~!@#$%^&*()-+={}<>[]/?.,".ToCharArray();

            return passwordChars;
        }

        private string GetRandomCharacter(char[] array)
        {
            Random random = new Random();
            string character = array.GetValue(random.Next(0, array.Length)).ToString();

            return character;
        }
    }
}

