using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Netension.Extensions.Security
{
    public static class SecureStringExtensions
    {
        public static string Decrypt(this SecureString value)
        {
            var valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }

        public static SecureString Encrypt(this string value)
        {
            var result = new SecureString(); 
            result.Clear();

            foreach (char c in value)
            {
                result.AppendChar(c);
            }
            return result;
        }
    }
}
