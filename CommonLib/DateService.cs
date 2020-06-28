using System;

namespace CommonLib
{
    public class DateService : IDateService
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}