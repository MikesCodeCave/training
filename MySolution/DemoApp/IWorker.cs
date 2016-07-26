using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    interface IWorker
    {
        int StartWork();
        void StopWork();
    }
}
