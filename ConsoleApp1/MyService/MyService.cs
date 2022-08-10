using System;
using System.Collections.Generic;
using System.Text;

 namespace SL.MyService
{
    public interface IMyService
    {
        string GetWelcome(DateTime? date);
    }

    public class MyService:IMyService
    {
        public string  GetWelcome(DateTime? date)
        {
            return "Hello in my App, today is "+ date.Value.ToShortDateString();
        }
        public string GetWelcome2(DateTime? date)
        {
            return "Hello in my App, today is " + date.Value.ToLongDateString();
        }
    }
}
