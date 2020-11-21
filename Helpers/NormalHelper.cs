using System;
using System.Collections.Generic;
using System.Text;

namespace BigData.Helpers
{
    public static class NormalHelper
    {
        public static string GenerateNormalKey()
        {
            return DateTime.Now.ToString().GetHashCode().ToString("x");
        }
    }
}
