using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Message
    {

        ITime _time;
        string MessageToReturn = "no";
        string UserName;


        public Message(ITime time)
        {
            this._time = time;
            this.UserName = Environment.UserName;
        }

        public string GetHelloMessage()
        {
            if (this._time.TimeNow.DayOfWeek == DayOfWeek.Saturday
                || this._time.TimeNow.DayOfWeek == DayOfWeek.Sunday
                || this._time.TimeNow.DayOfWeek == DayOfWeek.Friday && this._time.TimeNow.Hour > 18
                || this._time.TimeNow.DayOfWeek == DayOfWeek.Monday && this._time.TimeNow.Hour < 9
                )
            {
                MessageToReturn = "Bon weekend " + UserName;
            }
            else if (this._time.TimeNow.Hour >= 9 && this._time.TimeNow.Hour < 13)
            {
                MessageToReturn = "Bonjour " + UserName;
            }
            else if (this._time.TimeNow.Hour >= 13 && this._time.TimeNow.Hour < 18)
            {
                MessageToReturn = "Bonne aprem " + UserName;
            }
            else
            {
                MessageToReturn = "Bonsoir " + UserName;
            }
            
            return MessageToReturn;
        }
    }
}
