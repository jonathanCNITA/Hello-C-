using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace UnitTesMessageClass
{
    class FakeTime : ITime
    {
        DateTime CustomTime;

        public FakeTime(DateTime time)
        {
            this.CustomTime = time;
        }

        public DateTime TimeNow
        {
            get
            {
                return this.CustomTime;
            }
        }
    }
}
