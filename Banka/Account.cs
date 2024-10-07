using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public static class Account
    {
        public static decimal UserDefaultBalance { get; set; } = 1000;
        public static string ActionStatus { get; set; }
    }

    public static class UserData
    {
        public static string Balance { get; set; }
        public static decimal AccountNumber { get; set; }
    }
    public static class UserSession
    {
        public static string VerifiedUsername { get; set; }
        public static string SenderAccountNumber { get; set; }
    }
}
