﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex.cs
{
/// UC7 creating regular expression for validating password with at least one numeric value
    class UserRegistration
    {
        //writing the valid pattern
        string password = "^[a-zA-Z]*[A-Z]*[0-9]+[a-zA-Z]*$";
        string[] inputs = { "abCd@e1fgh", "Aa1bc", "AABCDEEEFgghik" };

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