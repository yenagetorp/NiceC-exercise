using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    class SunResultModel1
    {
        //lookign at the json in sunsetsnd sunrise api,
        //we can see that results is an object which contains sunrise property and sunset property.
        //anthoer object is status.
        public SunModel1  Results { get; set; }
    }
}
