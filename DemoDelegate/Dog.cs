using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    public class Dog
    {
        public Handler Tiao;
        public void DogTiao()
        {
            var action = Tiao;
            if (Tiao != null)
            {
                action();
            }
        }
    }
}
