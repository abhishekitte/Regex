﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex.cs
{
/// UC4 creating regular expression for validating phone number
    class UserRegistration
    {
        //writing the valid pattern
        string phone = "^[0-9]{2}[  ]*[0-9]{10}$";
        string[] inputs = { "91 9967320888", "9930532545" };

        public void Validation()
        {
            Regex regex1 = new Regex(phone);
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