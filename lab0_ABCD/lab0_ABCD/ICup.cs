using System;
using System.Collections.Generic;
using System.Text;

namespace lab0_ABCD
{
    interface ICup
    {
        protected string Type { get; set; }

        protected string Capacity { get; set; }
        public void Refill();
        public void Wash();



    }
}
