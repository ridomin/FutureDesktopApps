using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedWinRT
{
    public sealed class WinRTTypes
    {
        public static bool IsDesignMode => Windows.ApplicationModel.DesignMode.DesignModeEnabled;

        public static string SaySomething()
        {
            return "hola";
            //return new Windows.Networking.HostName(Environment.MachineName).IPInformation.ToString();
        }
    }
}
