﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class spellString
    {
        public static string getRandomString()
        {
            string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            char []stringChars = new char[1];
            Random random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string finalString = new String(stringChars);

            return finalString;
        }

        public static string getdoubleRandomString()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] stringChars = new char[2];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new string(stringChars);

            return finalString;
        }

        public static string getTripleRandomString()
        {
            string chars = "][/-abcdeuvwxyz0123456789";
            char[] stringChars = new char[3];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            return finalString;
        }

        public static string getFourRandomString()
        {
            string chars = "][/-abcdeuvwxyz0123456789ABCRIWURI";
            char[] stringChars = new char[4];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            return finalString;
        }

        public static string getFiveRandomString()
        {
            string chars = "][/-WQXZabcdeuvwxyz0123456789ABCRIWURI";
            char[] stringChars = new char[5];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            return finalString;
        }

        public static string getSixRandomString()
        {
            string chars = "][/-WQXZabcdeuvwxyz0123456789ABCRIWURI?<>";
            char[] stringChars = new char[6];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            return finalString;
        }

        public static string getSixRandomString2()
        {
            string chars = "][/-?><)(AVBRopqrstuv18593-+";
            char[] stringChars = new char[6];
            Random random = new Random();
            string finalString;

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            finalString = new String(stringChars);

            return finalString;
        }
    }
}
