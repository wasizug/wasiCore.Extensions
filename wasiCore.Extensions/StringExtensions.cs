using System;
using System.Collections.Generic;

namespace wasiCore.Extensions
{
    public static class StringExtensions
    {


        /// <summary>
        /// Returns a new string in which all leading and trailing occurrences of a set of unwanted characters (between char 0 and 32) from the current string are removed
        /// </summary>
        /// <param name="str">String: The string that remains after all unwanted characters are removed from the start and end of the current string. If no characters can be trimmed from the current instance, the method returns the current instance unchanged.</param>
        /// <returns></returns>
        public static string TrimExtended(this string str)
        {
            var s = str;

            if (s == null)
                return null;

            var unwantedCharList = new List<char>();
            for (var i = 0; i <= 32; i++)
                unwantedCharList.Add((char)i);

            return s.Trim(unwantedCharList.ToArray());
        }



        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public static string SubstringExtended(this string str, int startIndex)
        {
            return str.Substring(startIndex);
        }


        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string SubstringExtended(this string str, int startIndex, int length)
        {
            return str.Substring(startIndex, Math.Min(str.Length - startIndex, length));
        }


        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at the first position and has a specified length.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Left(this string str, int length)
        {
            if (length < 0)
                length = 0;
            return str.SubstringExtended(0, length);
        }



        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Right(this string str, int length)
        {
            if (length > str.Length)
                length = str.Length;
            if (length < 0)
                length = 0;
            return str.SubstringExtended(str.Length - length >= 0 ? str.Length - length : str.Length, str.Length);
        }


    }
}
