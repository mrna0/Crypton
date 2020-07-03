﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Crypton
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World";
            int key = 11;

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Encrypt: {Crypt(message, key)}");

            string encrypted = Crypt(message, key);

            Console.WriteLine($"Decrypt: {Crypt(encrypted, key)}");
            Console.ReadLine();
        }

        static string Crypt(string message, int key)
        {
            string cryptedMessage = null;

            foreach (int item in message)
            {
                cryptedMessage += (char) (item ^ key);
            }

            return cryptedMessage;
        }
    }
}
