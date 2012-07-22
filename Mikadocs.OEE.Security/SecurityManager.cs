using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Mikadocs.OEE.Security
{
    public static class SecurityManager
    {
        private const string keyName = "Software\\MikadoConsult\\OEE\\ManagementConsole";
        private const string canEditManagementConsoleValueName = "CanEditManagementConsole";
        public static bool CanEditManagementConsole
        {
            get
            {
                var key = OpenKey(false);

                return bool.Parse(key.GetValue(canEditManagementConsoleValueName, bool.FalseString).ToString());
            }
            set
            {
                var key = OpenKey(true);

                key.SetValue(canEditManagementConsoleValueName, value.ToString());
            }
        }

        private static RegistryKey OpenKey(bool writable)
        {
            var key = Registry.CurrentUser.OpenSubKey(keyName, writable);
            if (key == null)
            {
                Registry.CurrentUser.CreateSubKey(keyName);
                return OpenKey(writable);
            }

            return key;
        }
    }
}
