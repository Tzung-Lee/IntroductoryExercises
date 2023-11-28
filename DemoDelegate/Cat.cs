using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    public delegate void Handler();
    public class Cat
    {
        public Handler Miao;

        public void MiaoMiao()
        {
            var action = Miao;
            if (action != null)
            {
                action();
            }
        }
    }
}
