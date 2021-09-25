﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex.cs

/// UC6 creating regular expression for validating password with at least one uppercase
    class UserRegistration
    {
        //writing the valid pattern
        string password = "^[a-zA-Z]{1,}[A-Z]{1,}[a-zA-Z]*";
        string[] inputs = { "abcdefgh", "abc", "AABCDEEEFgghik" };

        public void Validation()
        {
            Regex regex1 = new Regex(password);
            Console.WriteLine("Validating Email id: ");
            ItarateLoop(inputs, regex1);
        }
        public void ItarateLoop(string[] arr, Regex regex1)
        {
            for (int i = 0; i < arr.Length; i++)//validation Loop
            {
                bool result = regex1.IsMatch(arr[i]);
                if (result)
                {
                    Console.WriteLine(arr[i] + ": is-->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + ": is-->" + "Invalid");
                }
            }
        }
    }
}