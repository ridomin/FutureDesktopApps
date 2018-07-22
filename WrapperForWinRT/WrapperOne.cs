using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperForWinRT
{
    public class WrapperOne
    {
        public static bool IsDesignModeEnabled => true; // ManagedWinRT.WinRTTypes.IsDesignMode;

        public static string SaySomething()
        {
            
          return   ManagedWinRT.WinRTTypes.SaySomething();
        }
    }
}
