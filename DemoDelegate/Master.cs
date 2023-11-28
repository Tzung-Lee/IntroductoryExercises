using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    public class Master
    {
        public Handler Han;
        public void HanJiao()
        {
            var action = Han;
            if (action != null)
            {
                action();
            }
        }
    }
}
