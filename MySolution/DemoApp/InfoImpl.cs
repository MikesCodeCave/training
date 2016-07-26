using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class InfoImpl : IInfo
    {
        public string GetAuthor()
        {
            return "MScott";
        }

        public string GetDate()
        {
            return "July 26, 2016";
        }

        public string GetVersion()
        {
            return "1.0";
        }
    }
}
