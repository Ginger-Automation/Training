﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Training
{
    public class Strings
    {
        public static string Concat(string text1, string text2)
        {
            return string.Concat(text1, text2);
        }

        internal static int GetLengthOfString_Click(string str)
        {
            return str.Length;
        }

        internal static void ConcatThreeStrings()
        {
            throw new NotImplementedException();
        }
    }
}
