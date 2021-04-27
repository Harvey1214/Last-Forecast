using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    static class Security
    {
        private static int keyMultiplier = 193;
        private static int keyAddition = 712;

        private static string separator = "*&";

        public static string Encrypt(string text)
        {
            return $"*^/7{separator}{StringToUnicode(text)}";
        }

        public static string Decrypt(string text)
        {
            if (IsEncrypted(text) == false)
            {
                return text;
            }

            return UnicodeToString(text);
        }

        private static bool IsEncrypted(string text)
        {
            if (text == null) return false;
            if (text.Length < 4) return false;

            if (text.Substring(0, 4) == "*^/7")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string StringToUnicode(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                int num = c;
                result += $"{EncryptNumber(num)}{separator}";
            }

            return result;
        }

        private static string UnicodeToString(string text)
        {
            string[] nums = text.Split(new string[] { separator }, StringSplitOptions.None);
            string result = "";
            foreach (string numText in nums)
            {
                int num = 0;
                bool success = Int32.TryParse(numText, out num);

                if (success) result += (char)DecryptNumber(num);
            }

            return result;
        }

        private static int EncryptNumber(int num)
        {
            num *= keyMultiplier;
            num += keyAddition;

            return num;
        }

        private static int DecryptNumber(int num)
        {
            num -= keyAddition;
            num /= keyMultiplier;

            return num;
        }
    }
}
